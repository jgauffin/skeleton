﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace Skeleton.Web.Cards
{
    public interface IProjectsClient
    {
        Task<IEnumerable<string>> GetProjectNames();
        Task<Dictionary<string, string>> GetProjectPriorityFieldNames(IEnumerable<string> projectName);
    }
}