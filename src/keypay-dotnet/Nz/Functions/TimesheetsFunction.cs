using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Nz.Enums;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Models.Timesheets;

namespace KeyPayV2.Nz.Functions
{
    public interface ITimesheetsFunction
    {
        List<NzTimesheetLineModel> GetBusinessTimesheets(int businessId, string query, ODataQuery oDataQuery = null);
        Task<List<NzTimesheetLineModel>> GetBusinessTimesheetsAsync(int businessId, string query, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        NzIndividualTimesheetLineModel CreateTimesheetLine(int businessId, NzIndividualTimesheetLineModel request);
        Task<NzIndividualTimesheetLineModel> CreateTimesheetLineAsync(int businessId, NzIndividualTimesheetLineModel request, CancellationToken cancellationToken = default);
        NzIndividualTimesheetLineModel UpdateTimesheetLine(int businessId, int timesheetLineId, NzIndividualTimesheetLineModel request);
        Task<NzIndividualTimesheetLineModel> UpdateTimesheetLineAsync(int businessId, int timesheetLineId, NzIndividualTimesheetLineModel request, CancellationToken cancellationToken = default);
        void DeleteTimesheetLine(int businessId, int timesheetLineId);
        Task DeleteTimesheetLineAsync(int businessId, int timesheetLineId, CancellationToken cancellationToken = default);
        NzSubmitTimesheetsResponse UpdateReplaceTimesheets(int businessId, NzSubmitTimesheetsRequest request);
        Task<NzSubmitTimesheetsResponse> UpdateReplaceTimesheetsAsync(int businessId, NzSubmitTimesheetsRequest request, CancellationToken cancellationToken = default);
        NzSubmitTimesheetsResponse BulkInsertTimesheets(int businessId, NzSubmitTimesheetsRequest request);
        Task<NzSubmitTimesheetsResponse> BulkInsertTimesheetsAsync(int businessId, NzSubmitTimesheetsRequest request, CancellationToken cancellationToken = default);
    }
    public class TimesheetsFunction : BaseFunction, ITimesheetsFunction
    {
        public TimesheetsFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// Get Business Timesheets
        /// </summary>
        /// <remarks>
        /// Retrieves all timesheets for the specified business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public List<NzTimesheetLineModel> GetBusinessTimesheets(int businessId, string query, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<NzTimesheetLineModel>>($"/business/{businessId}/timesheet{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// Get Business Timesheets
        /// </summary>
        /// <remarks>
        /// Retrieves all timesheets for the specified business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<NzTimesheetLineModel>> GetBusinessTimesheetsAsync(int businessId, string query, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<NzTimesheetLineModel>>($"/business/{businessId}/timesheet{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create timesheet line
        /// </summary>
        /// <remarks>
        /// Create an individual timesheet line
        /// IMPORTANT NOTICE: If units are specified the start and end time will be changed to midnight
        /// </remarks>
        public NzIndividualTimesheetLineModel CreateTimesheetLine(int businessId, NzIndividualTimesheetLineModel request)
        {
            return ApiRequest<NzIndividualTimesheetLineModel,NzIndividualTimesheetLineModel>($"/business/{businessId}/timesheet", request, Method.Post);
        }

        /// <summary>
        /// Create timesheet line
        /// </summary>
        /// <remarks>
        /// Create an individual timesheet line
        /// IMPORTANT NOTICE: If units are specified the start and end time will be changed to midnight
        /// </remarks>
        public Task<NzIndividualTimesheetLineModel> CreateTimesheetLineAsync(int businessId, NzIndividualTimesheetLineModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<NzIndividualTimesheetLineModel,NzIndividualTimesheetLineModel>($"/business/{businessId}/timesheet", request, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Update timesheet line
        /// </summary>
        /// <remarks>
        /// Update an individual timesheet line
        /// IMPORTANT NOTICE: If units are specified the start and end time will be changed to midnight
        /// </remarks>
        public NzIndividualTimesheetLineModel UpdateTimesheetLine(int businessId, int timesheetLineId, NzIndividualTimesheetLineModel request)
        {
            return ApiRequest<NzIndividualTimesheetLineModel,NzIndividualTimesheetLineModel>($"/business/{businessId}/timesheet/{timesheetLineId}", request, Method.Put);
        }

        /// <summary>
        /// Update timesheet line
        /// </summary>
        /// <remarks>
        /// Update an individual timesheet line
        /// IMPORTANT NOTICE: If units are specified the start and end time will be changed to midnight
        /// </remarks>
        public Task<NzIndividualTimesheetLineModel> UpdateTimesheetLineAsync(int businessId, int timesheetLineId, NzIndividualTimesheetLineModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<NzIndividualTimesheetLineModel,NzIndividualTimesheetLineModel>($"/business/{businessId}/timesheet/{timesheetLineId}", request, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Delete timesheet line
        /// </summary>
        /// <remarks>
        /// Delete an individual timesheet line.
        /// Note: You cannot delete a Processed timesheet line.
        /// </remarks>
        public void DeleteTimesheetLine(int businessId, int timesheetLineId)
        {
            ApiRequest($"/business/{businessId}/timesheet/{timesheetLineId}", Method.Delete);
        }

        /// <summary>
        /// Delete timesheet line
        /// </summary>
        /// <remarks>
        /// Delete an individual timesheet line.
        /// Note: You cannot delete a Processed timesheet line.
        /// </remarks>
        public Task DeleteTimesheetLineAsync(int businessId, int timesheetLineId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/timesheet/{timesheetLineId}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// Update/Replace timesheets
        /// </summary>
        /// <remarks>
        /// Performs the same action as 'Bulk Insert Timesheets', but any existing timesheets
        /// for the specified employees within the specified time period
        /// (StartTime - EndTime) will be replaced with the timesheets specified.
        /// </remarks>
        public NzSubmitTimesheetsResponse UpdateReplaceTimesheets(int businessId, NzSubmitTimesheetsRequest request)
        {
            return ApiRequest<NzSubmitTimesheetsResponse,NzSubmitTimesheetsRequest>($"/business/{businessId}/timesheet/bulk", request, Method.Put);
        }

        /// <summary>
        /// Update/Replace timesheets
        /// </summary>
        /// <remarks>
        /// Performs the same action as 'Bulk Insert Timesheets', but any existing timesheets
        /// for the specified employees within the specified time period
        /// (StartTime - EndTime) will be replaced with the timesheets specified.
        /// </remarks>
        public Task<NzSubmitTimesheetsResponse> UpdateReplaceTimesheetsAsync(int businessId, NzSubmitTimesheetsRequest request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<NzSubmitTimesheetsResponse,NzSubmitTimesheetsRequest>($"/business/{businessId}/timesheet/bulk", request, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Bulk Insert Timesheets
        /// </summary>
        /// <remarks>
        /// Adds timesheets for the specified business. This will not replace any existing timesheets.
        /// The timesheets should be grouped by their associated employee IDs, with the key for the timesheet array
        /// being the employee ID. For a Standard Employee ID Type, make sure the employee ID is an integer.
        /// IMPORTANT NOTICE: If units are specified the start and end time will be changed to midnight
        /// </remarks>
        public NzSubmitTimesheetsResponse BulkInsertTimesheets(int businessId, NzSubmitTimesheetsRequest request)
        {
            return ApiRequest<NzSubmitTimesheetsResponse,NzSubmitTimesheetsRequest>($"/business/{businessId}/timesheet/bulk", request, Method.Post);
        }

        /// <summary>
        /// Bulk Insert Timesheets
        /// </summary>
        /// <remarks>
        /// Adds timesheets for the specified business. This will not replace any existing timesheets.
        /// The timesheets should be grouped by their associated employee IDs, with the key for the timesheet array
        /// being the employee ID. For a Standard Employee ID Type, make sure the employee ID is an integer.
        /// IMPORTANT NOTICE: If units are specified the start and end time will be changed to midnight
        /// </remarks>
        public Task<NzSubmitTimesheetsResponse> BulkInsertTimesheetsAsync(int businessId, NzSubmitTimesheetsRequest request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<NzSubmitTimesheetsResponse,NzSubmitTimesheetsRequest>($"/business/{businessId}/timesheet/bulk", request, Method.Post, cancellationToken);
        }
    }
}
