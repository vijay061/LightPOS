﻿using FluentNHibernate.Mapping;
using NickAc.LightPOS.Backend.Objects;

namespace NickAc.LightPOS.Backend.Mapping
{
    public class CategoryMap : ClassMap<Category>
    {
        public CategoryMap()
        {
            Table("Categories");
            Id(x => x.ID).GeneratedBy.Native();
            Map(x => x.Name);
            Map(x => x.Color).CustomType<ColorUserType>();
        }
    }
}