using System;
using System.Collections.Generic;
using System.Linq;
using BlazorGetJson.Models;

namespace BlazorGetJson.Services
{
    public class PaginationService
    {
        private ReportsModel _report;
        private DateTime _currentWeekStart;
        private DateTime _currentWeekEnd;

        private DateTime _startDate;
        private DateTime _endDate;

        private DateTime _toDate;
        private int _currentPage;

        public void Initialize(ReportsModel report)
        {
            _report = report;
            _currentPage = 1;

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
        }

        public IEnumerable<KeyValuePair<string, Record>> GetCurrentPageRecords()
        {
            //var records = _report.Records
            //    .Where(r => DateTime.Parse(r.Key) >= _currentWeekStart && DateTime.Parse(r.Key) < _currentWeekEnd)
            //    .ToList();
            //var pagedRecords = records.Skip((_currentPage - 1) * _itemsPerPage).Take(_itemsPerPage);
            //return pagedRecords;
            return _report.Records.Where(r => DateTime.Parse(r.Key) >= _currentWeekStart && DateTime.Parse(r.Key) < _currentWeekEnd);
        }

        public void NextPage()
        {
            if (_currentWeekEnd < _toDate)
            {
                _currentWeekStart = _currentWeekStart.AddDays(7);
                _currentWeekEnd = _currentWeekEnd.AddDays(7);

            }  
        }

        public void PreviousPage()
        {
            if (_startDate < _currentWeekStart)
            {
                _currentWeekStart = _currentWeekStart.AddDays(-7);
                _currentWeekEnd = _currentWeekEnd.AddDays(-7);
            }

            // if (_currentPage > 1)
            // {
            //     _currentWeekStart = _currentWeekStart.AddDays(-7);
            //     _currentWeekEnd = _currentWeekEnd.AddDays(-7);
            //     _currentPage--;
            // }
        }

        // public int TotalPages => (int)Math.Ceiling((double)records.Count / _itemsPerPage);
        // public int CurrentPage => _currentPage;

        // private List<KeyValuePair<string, Record>> records => _report.Records
        //     .Where(r => DateTime.Parse(r.Key) >= _currentWeekStart && DateTime.Parse(r.Key) < _currentWeekEnd)
        //     .ToList();
    }
}
