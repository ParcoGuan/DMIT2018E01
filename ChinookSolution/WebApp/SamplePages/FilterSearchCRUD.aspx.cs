using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

#region Additional Namespaces
using ChinookSystem.BLL;
using ChinookSystem.Data.Entities;
#endregion

namespace WebApp.SamplePages
{
    public partial class FilterSearchCRUD : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindArtistList();
<<<<<<< HEAD
<<<<<<< HEAD
=======
                //set the max value for the Validation control
                //RangeEditReleaseYear
                RangeEditReleaseYear.MaximumValue = DateTime.Today.Year.ToString();
>>>>>>> 597c2c187e8c192348c55bca9bdbae0d87436087
=======
                //set the max value for the Validation control
                //RangeEditReleaseYear
                RangeEditReleaseYear.MaximumValue = DateTime.Today.Year.ToString();
>>>>>>> 597c2c187e8c192348c55bca9bdbae0d87436087
            }
        }

        protected void BindArtistList()
        {
            ArtistController sysmgr = new ArtistController();
            List<Artist> info = sysmgr.Artist_List();
            info.Sort((x, y) => x.Name.CompareTo(y.Name));
            ArtistList.DataSource = info;
            ArtistList.DataTextField = nameof(Artist.Name);
            ArtistList.DataValueField = nameof(Artist.ArtistId);
            ArtistList.DataBind();
            //ArtistList.Items.Insert(0, "select ...");
        }

<<<<<<< HEAD
<<<<<<< HEAD
=======
=======
>>>>>>> 597c2c187e8c192348c55bca9bdbae0d87436087
        //in code behind to be called from ODS
        protected void CheckForException(object sender, ObjectDataSourceStatusEventArgs e)
        {
            MessageUserControl.HandleDataBoundException(e);
        }


<<<<<<< HEAD
>>>>>>> 597c2c187e8c192348c55bca9bdbae0d87436087
=======
>>>>>>> 597c2c187e8c192348c55bca9bdbae0d87436087
        protected void AlbumList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //standard lookup
            GridViewRow agvrow = AlbumList.Rows[AlbumList.SelectedIndex];
            //retreive the value from a web control located within
            //   the GridView cell
            string albumid = (agvrow.FindControl("AlbumId") as Label).Text;

            //error handling will need to be added
<<<<<<< HEAD
<<<<<<< HEAD
            AlbumController sysmgr = new AlbumController();
            Album datainfo = sysmgr.Album_Get(int.Parse(albumid));
            if (datainfo == null)
            {
                //clear the controls
                //throw an exception
            }
            else
            {
                EditAlbumID.Text = datainfo.AlbumId.ToString();
                EditTitle.Text = datainfo.Title;
                EditAlbumArtistList.SelectedValue = datainfo.ArtistId.ToString();
                EditReleaseYear.Text = datainfo.ReleaseYear.ToString();
                EditReleaseLabel.Text =
                    datainfo.ReleaseLabel == null ? "" : datainfo.ReleaseLabel;
            }
=======
=======
>>>>>>> 597c2c187e8c192348c55bca9bdbae0d87436087
            MessageUserControl.TryRun(() =>
            {
                //place your processing code
                AlbumController sysmgr = new AlbumController();
                Album datainfo = sysmgr.Album_Get(int.Parse(albumid));
                
                if (datainfo == null)
                {
                    //ClearControls();
                    throw new Exception("Record no longer exists on file.");
                }
                else
                {
                    EditAlbumID.Text = datainfo.AlbumId.ToString();
                    EditTitle.Text = datainfo.Title;
                    EditAlbumArtistList.SelectedValue = datainfo.ArtistId.ToString();
                    EditReleaseYear.Text = datainfo.ReleaseYear.ToString();
                    EditReleaseLabel.Text =
                        datainfo.ReleaseLabel == null ? "" : datainfo.ReleaseLabel;
                }
            },"Find Album", "Album found"); //strings on this line are success message
           
<<<<<<< HEAD
>>>>>>> 597c2c187e8c192348c55bca9bdbae0d87436087
=======
>>>>>>> 597c2c187e8c192348c55bca9bdbae0d87436087
        }
    }
}