using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Scaffolding;
using Microsoft.EntityFrameworkCore.Scaffolding.Internal;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Sqlite.Storage.Internal;
using PonyDbContextScaffold;
using PonyDbContextScaffold.GenCustomClasses;

namespace PonySample
{


    public class PonyCSharpEntityTypeGenerators : ICSharpEntityTypeGenerators
    {
        public EntityT4GeneratorBase[] generators
        {
            get
            {
                EntityT4GeneratorBase[] gen = new EntityT4GeneratorBase[] {
                    new XFormGrid (),
                    new XFormGridXaml (),
                    new WinFormGridView(),
                    new PonySample.CustomGenerators.SampleGenerator ()

                };

                return gen;

            }
        }
    }


    

    public class PonySampleDesignTimeServices : IDesignTimeServices
    {
        public void ConfigureDesignTimeServices(IServiceCollection serviceCollection)
        {

            /* gen custom UI class start */

            CodeGenConfigBase cgc = new CodeGenConfigBase();
            cgc.UIClassOnly = true;

                 
            serviceCollection.AddSingleton<CodeGenConfigBase>();
            serviceCollection.AddSingleton<IModelCodeGenerator, PonyCSharpModelGenerator>();
            serviceCollection.AddSingleton<ICSharpEntityTypeGenerators, PonyCSharpEntityTypeGenerators>();


            /* gen custom UI class end */



            serviceCollection.AddSingleton<IRelationalTypeMappingSource, PonySqliteTypeMappingSource>();




        }
    }



}
