﻿using AutoMapper;

namespace CallApp.Infrastruction.Mapper
{
    public static class Mapping
    {
        public static TTarget Map<TSource, TTarget>(TSource value)
            where TSource : class
            where TTarget : class
        {
            var config = new MapperConfiguration(cfg =>
                cfg.CreateMap<TSource, TTarget>());

            var mapper = new AutoMapper.Mapper(config);
            var result = mapper.Map<TSource, TTarget>(value);

            return result;
        }
    }
}