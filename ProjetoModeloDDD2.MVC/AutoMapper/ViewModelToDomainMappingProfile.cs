﻿using AutoMapper;
using ProjetoModeloDDD2.Domain.Entities;
using ProjetoModeloDDD2.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoModeloDDD2.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected void Configure()
        {
            Mapper.Initialize(cfg => {
                cfg.CreateMap<ClienteViewModel, Cliente>();
            });

            var source = new ClienteViewModel();
            var dest = Mapper.Map<ClienteViewModel, Cliente>(source);

            //Mapper.CreateMap<ClienteViewModel, Cliente>();
            //Mapper.CreateMap<ProdutoViewModel, Produto>();


            Mapper.Initialize(cfg => {
                cfg.CreateMap<ProdutoViewModel, Produto>();
            });

            var source1 = new ProdutoViewModel();
            var dest1 = Mapper.Map<ProdutoViewModel, Produto>(source1);
        }


    }
}