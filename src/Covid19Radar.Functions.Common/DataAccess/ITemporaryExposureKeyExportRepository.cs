﻿using Covid19Radar.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Covid19Radar.DataAccess
{
    public interface ITemporaryExposureKeyExportRepository
    {
        Task<TemporaryExposureKeyExportModel> CreateAsync();
        Task<TemporaryExposureKeyExportModel> GetAsync(string id);
        Task UpdateAsync(TemporaryExposureKeyExportModel model);
        Task<TemporaryExposureKeyExportModel[]> GetKeysAsync(long sinceEpochSeconds);

    }
}
