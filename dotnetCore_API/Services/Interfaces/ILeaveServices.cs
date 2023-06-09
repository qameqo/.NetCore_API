﻿using dotnetCore_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetCore_API.Services.Interfaces
{
    public interface ILeaveServices
    {
        public List<GetLeaveModel> GetListLeave(GetLeaveModel data);
        public ResponseModel AddLeave(List<LeaveModel> data);
        public ResponseModel ChangeLeave(List<LeaveModel> data);
        public ResponseModel DeleteLeave(List<LeaveModel> data);
        public Task<ResponseModel> AddListLeave(List<LeaveModel> data);
    }
}
