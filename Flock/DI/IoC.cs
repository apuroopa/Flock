// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IoC.cs" company="Web Advanced">
// Copyright 2012 Web Advanced (www.webadvanced.com)
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0

// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


using System.Data.Entity;
using Flock.DataAccess.EntityFramework;
using Flock.DataAccess.Repositories.Concrete;
using Flock.DataAccess.Repositories.Interfaces;
using Flock.Facade.Concrete;
using Flock.Facade.Interfaces;
using StructureMap;

namespace Flock.DI {
    public static class IoC {
        public static IContainer Initialize() {
            ObjectFactory.Initialize(x =>
                        {
                            x.Scan(scan => { 
                                scan.TheCallingAssembly();
                                scan.WithDefaultConventions();
                            });
                            
                            //x.For<IDocumentStore>().Singleton().Use(
                            //   () =>
                            //   {
                            //       var store = new DocumentStore
                            //       {
                            //           ConnectionStringName = "RavenDbConnection"
                            //       };
                            //       store.Initialize();
                            //       store.JsonRequestFactory.DisableRequestCompression = true;
                            //       return store;
                            //   });
                            
                            //x.For<IDocumentSession>().HttpContextScoped().Use(ctx => ctx.GetInstance<IDocumentStore>().OpenSession());
                            x.For<DbContext>().Use<FlockContext>();
                            x.For<IMessageFacade>().Use<MessageFacade>();
                            x.For<IUserFacade>().Use<UserFacade>();
                            x.For<IUserRepository>().Use<UserRepository>();

                        });
            return ObjectFactory.Container;
        }
    }
}