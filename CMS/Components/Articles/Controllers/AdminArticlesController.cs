﻿using ComArticles.Models;
using ComArticles.Services;
using ComArticles.ViewModels;
using Omu.ValueInjecter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComArticles
{
    public class AdminArticlesController : Controller
    {
        IArticlesService articlesService = null;
        public AdminArticlesController(IArticlesService articlesService)
        {
            this.articlesService = articlesService;
        }

        public ActionResult ArticlesList()
        {
            var models = articlesService.GetAllArticles();

            List<ArticleViewModel> viewModelList = models
                .Select(x => new ArticleViewModel()
                .InjectFrom(x))
                .Cast<ArticleViewModel>()
                .ToList();

            return View("~/Components/ComArticles/Views/Admin/ArticlesList.cshtml", viewModelList);
        }
    }
}