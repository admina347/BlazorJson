using BlazorGetJson.Models;

namespace BlazorGetJson.Services;

public class PaginationTagService
{
    private TagsModel _report;
    private DateTime _currentWeekStart;
    private DateTime _currentWeekEnd;
    
    public DateOnly From { get; set; }
    public DateOnly To { get; set; }

    private DateTime _startDate;
    private DateTime _endDate;

    private DateTime _toDate;

    public void Initialize(TagsModel report)
    {
        _report = report;

        // Calculate the start and end of the current week based on the From and To filters
        SetCurrentWeek();
    }

    private void SetCurrentWeek()
    {
        // Assuming the From and To filters are DateTimeOffset
        DateTimeOffset fromDateOffset = _report.Request.Filters.From;
        DateTimeOffset toDateOffset = _report.Request.Filters.To;

        // Convert DateTimeOffset to DateTime
        DateTime fromDate = fromDateOffset.DateTime;
        _toDate = toDateOffset.DateTime;

        // Calculate the start and end of the current week
        _currentWeekStart = fromDate.Date;    //fromDate.AddDays((DateTime.Now - fromDate).Days % 7);
        _startDate = fromDate.Date;
        _endDate = _toDate.Date;

        _currentWeekEnd = _currentWeekStart.AddDays(7);

        From = DateOnly.FromDateTime(_currentWeekStart);
        To = DateOnly.FromDateTime(_currentWeekEnd.AddDays(-1));
    }

    public IEnumerable<KeyValuePair<string, Dictionary<string, int>>> GetCurrentPageRecords()
    {
        return _report.Records.Where(r => DateTime.Parse(r.Key) >= _currentWeekStart && DateTime.Parse(r.Key) < _currentWeekEnd);
    }

    public void NextPage()
    {
        if (_currentWeekEnd < _toDate)
        {
            _currentWeekStart = _currentWeekStart.AddDays(7);
            _currentWeekEnd = _currentWeekEnd.AddDays(7);
            From = DateOnly.FromDateTime(_currentWeekStart);
            To = DateOnly.FromDateTime(_currentWeekEnd.AddDays(-1));
        }  
    }

    public void PreviousPage()
    {
        if (_startDate < _currentWeekStart)
        {
            _currentWeekStart = _currentWeekStart.AddDays(-7);
            _currentWeekEnd = _currentWeekEnd.AddDays(-7);
            From = DateOnly.FromDateTime(_currentWeekStart);
            To = DateOnly.FromDateTime(_currentWeekEnd.AddDays(-1));
        }
    }
}
