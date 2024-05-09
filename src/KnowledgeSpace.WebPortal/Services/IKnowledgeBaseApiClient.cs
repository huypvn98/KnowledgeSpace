﻿using KnowledgeSpace.ViewModels;
using KnowledgeSpace.ViewModels.Contents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KnowledgeSpace.WebPortal.Services
{
    public interface IKnowledgeBaseApiClient
    {
        Task<List<KnowledgeBaseQuickVm>> GetPopularKnowledgeBases(int take);

        Task<List<KnowledgeBaseQuickVm>> GetLatestKnowledgeBases(int take);

        Task<List<LabelVm>> GetPopularLabels(int take);

        Task<Pagination<KnowledgeBaseQuickVm>> GetKnowledgeBasesByCategoryId(int categoryId, int pageIndex, int pageSize);

        Task<KnowledgeBaseVm> GetKnowledgeBaseDetail(int id);

        Task<List<LabelVm>> GetLabelsByKnowledgeBaseId(int id);
    }
}