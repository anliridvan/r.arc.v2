using AgileObjects.AgileMapper.Configuration;
using R.ARC.Common.Helper.Attributes;
using R.ARC.Common.Helper.Enums;
using R.ARC.Common.Helper.Extensions;
using R.ARC.Common.Helper.Paging;
using R.ARC.Core.Entity;
using R.ARC.Common.Contract;
using System;
using System.Collections.Generic;
using System.Linq;

namespace R.ARC.Util.Mapping.Config
{
    internal class CustomMapperConfiguration : MapperConfiguration
    {
        protected override void Configure()
        {
            MapParameter();
            MapAddress();
            MapTask();
        }


        private void MapTask()
        {
            //WhenMapping
            //    .From<TaskEntity>()
            //    .To<TaskModel>()
            //    .Map((e, dto) => e.Responsibles != null ? e.Responsibles.Select(m => m) : null)
            //    .To(dto => dto.Responsibles);

            //GetPlansFor<TaskEntity>().To<TaskModel>();

            //WhenMapping
            //    .From<TaskModel>()
            //    .To<TaskEntity>()
            //    .IgnoreTargetMembersWhere(m => m.HasAttribute<IgnoreMappingAttribute>())
            //    .And
            //    .Map((e, dto) => e.Responsibles != null ? e.Responsibles.ConvertString(',') : null)
            //    .To(dto => dto.ResponsiblesStr)
            //    ;

            //GetPlansFor<TaskModel>().To<TaskEntity>();

            //WhenMapping
            //    .From<TaskEntity>()
            //    .To<TaskBasicModel>()
            //    .Map((e, dto) => e.Responsibles != null ? e.Responsibles.Select(m => m) : null)
            //    .To(dto => dto.Responsibles)
            //    ;

            GetPlansFor<TaskEntity>().To<TaskBasicModel>();

        }

        private void MapParameter()
        {
            WhenMapping
                .From<ListParameterModel>()
                .To<PagedListParameters>()
                .Map((s, d) => new Page { Index = s.PageIndex.GetValueOrDefault(-1), Size = s.PageSize.GetValueOrDefault(-1) })
                .To(d => d.Page)
                .And
                .Map((s, d) => new List<Order> { new Order { IsAscending = s.SortOrder == "asc", Property = s.SortProperty } })
                .To(d => d.Orders)
                .And
                .Map((s, d) => new Filter { Value = s.FilterValue, Key = s.FilterKey })
                .To(d => d.Filter)
                ;

            GetPlansFor<ListParameterModel>().To<PagedListParameters>();
        }

        private void MapAddress()
        {


            WhenMapping
                .From<AddressModel>()
                .To<AddressEntity>()
                .IgnoreTargetMembersWhere(m => m.HasAttribute<IgnoreMappingAttribute>())
                .And
                .Map((dto, e) => string.Join(',', dto.Level))
                .To(e => e.LevelStr)
                .And
                .Map((dto, e) => string.Join(',', dto.LevelCode))
                .To(e => e.LevelCodeStr)
                ;

            GetPlansFor<AddressModel>().To<AddressEntity>();
        }


     
    

    }
}
