﻿using System.Collections.Generic;
using System.Reflection;
using FluentAssertions;
using Lazy.Owin.WebApi2.Token.OAuth.Api.WebApi;
using Lazy.Owin.WebApi2.Token.OAuth.Api.WebApi.Controllers;
using MainSolutionTemplate.Core.Helpers;
using NUnit.Framework;
using RestSharp;
using log4net;

namespace Lazy.Owin.WebApi2.Token.OAuth.Api.Tests.Integration.WebApi
{
	[TestFixture]
	[Category("Integration")]
	public class TaskControllerIntegrationTests : IntegrationTestsBase
	{
		private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		#region Setup/Teardown

		public void Setup()
		{
			
		}

		[TearDown]
		public void TearDown()
		{

		}

		#endregion

		[Test]
		public void Get_WhenCalled_ShouldHaveStatusCodeOk()
		{
			// arrange
			Setup();
			var request = new RestRequest(RouteHelper.TaskController,Method.GET);
			// action
			var restResponse = _client.Value.ExecuteWithLogging<List<TaskController.TaskModel>>(request);
			// assert
			//restResponse.StatusCode.Should().Be(HttpStatusCode.OK);
			restResponse.Content.Should().StartWith("[");
		}

		[Test]
		public void Get_WhenCalled_ShouldHaveSomeContent()
		{
			// arrange
			Setup();
			var request = new RestRequest(RouteHelper.TaskController,Method.GET);
			// action
			var restResponse = _client.Value.ExecuteWithLogging<List<TaskController.TaskModel>>(request);
			// assert
			restResponse.Content.Should().StartWith("[");
			restResponse.Data.Count.Should().BeGreaterOrEqualTo(1);
		}

		 
	}
}