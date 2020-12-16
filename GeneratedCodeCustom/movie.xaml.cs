


using Microsoft.EntityFrameworkCore;
using Syncfusion.SfDataGrid.XForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PonySample.GeneratedCodeCustom;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace NutrientDb.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EFGridViewmovie : EFGridViewBase<moviesContext>
    {

        //public DbContext _ctx;

        //public override DbContext ctx { get { return _ctx; }  set { _ctx = value; } }

        List<Picker> pickers = new List<Picker>();
        Picker cbodid = new Picker();


        public EFGridViewmovie()
        {
            InitializeComponent();

            ctx = new moviesContext();


            
            cbodirectorId .WidthRequest = 100;
            cbodirectorId .ItemsSource = ctx.Set<director>().ToList();
            cbodirectorId .SelectedIndexChanged += (object sender, EventArgs e) =>
            {
                GetQuery() ;
                //dataGrid.ItemsSource = GetQuery().ToList();


            };
            pickers.Add(cbodirectorId );
            stkFilters.Children.Add(cbodirectorId );

                


            
            GridTextColumn colmid = new GridTextColumn();
            colmid.MappingName = "mid";
            dataGrid.Columns.Add(colmid);


            GridTextColumn coldirectorId = new GridTextColumn();
            coldirectorId.MappingName = "directorId";
            dataGrid.Columns.Add(coldirectorId);


            GridTextColumn coltitle = new GridTextColumn();
            coltitle.MappingName = "title";
            dataGrid.Columns.Add(coltitle);



 

            GetQuery ();
        }


   

   
        public void GetQuery ()
        //public IQueryable<movie> GetQuery ()
        {
            var q = ctx.Set<movie>().AsQueryable<movie>();
            
            if (cbodirectorId.SelectedItem != null) q = q.Where(x => x.directorId == ((director)cbodirectorId.SelectedItem).directorId);



            dataGrid.ItemsSource = q.ToList () ;

  
        }


    

    }
}





