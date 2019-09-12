using chinoolsystem.BLL;
using chinoolsystem.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.SamplePages
{
    public partial class filterSearchPages : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindArtitsList();

            }
        }

        protected void BindArtitsList()
        {
            ArtistControl sysmer = new ArtistControl();
            List<Artist> info = sysmer.Artist_List();
            info.Sort((x, y) => x.Name.CompareTo(y.Name));

            ArtistList.DataSource = info;
            ArtistList.DataTextField = nameof(Artist.Name);
            ArtistList.DataTextField = nameof(Artist.ArtstieId);
            ArtistList.DataBind();
            ArtistList.Items.Insert(0, "select......");




        }
    }
}