//using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Text;

namespace PonySample.CustomGenerators
{
    public partial class SampleGenerator : PonyDbContextScaffold.GenCustomClasses.EntityT4GeneratorBase
    {
        public override string FileNamePrefix { get => ""; }
        public override string FileNamePostfix { get => "_sample"; }
        public override string Directory { get => "notused"; }
        public override string FileExtension { get => ".txt"; }



        public string GenColumns()
        {
            string tmp = $@"

            this.Url.DataPropertyName = ""Url"";
            this.Url.HeaderText = ""Url"";
            this.Url.MinimumWidth = 9;
            this.Url.Name = ""Url"";
            this.Url.Width = 175;
            
            ";

            

            //IProperty ii = null;
            return PerPropertyGen(tmp, "Url", p => p.Name);


        }


    }
}
