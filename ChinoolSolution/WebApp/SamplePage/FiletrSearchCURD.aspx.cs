using chinoolsystem.BLL;
using chinoolsystem.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.SamplePage
{
    public partial class FiletrSearchCURD : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
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
            ArtistList.DataTextField = nameof(Artist.ArtistId);
            ArtistList.DataBind();
            //ArtistList.Items.Insert(0, "select......");




        }

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
        protected void AlbumList_SelectedIndexChanged1(object sender, EventArgs e)
=======
        protected void AlbumList_SelectedIndexChanged(object sender, EventArgs e)
>>>>>>> 84ad18ad5f308d10caf570dca1653c3326a6222e
=======
        protected void AlbumList_SelectedIndexChanged(object sender, EventArgs e)
>>>>>>> 597c2c187e8c192348c55bca9bdbae0d87436087
=======
        protected void AlbumList_SelectedIndexChanged(object sender, EventArgs e)
>>>>>>> 597c2c187e8c192348c55bca9bdbae0d87436087
        {
            GridViewRow agvrow = AlbumList.Rows[AlbumList.SelectedIndex];
            //retreive the value from a web control located within
            //   the GridView cell
            string albumid = (agvrow.FindControl("AlbumId") as Label).Text;

            //error handling will need to be added
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            MessageUserControl.TryRun(() =>
            {
                AlbumControl sysmgr = new AlbumControl();
                Album datainfo = sysmgr.Album_Get(int.Parse(albumid));
                if (datainfo == null)
                {
                    //clear the controls
                    //throw an exception
                }
                else
                {
                    EditAlbumID.Text = datainfo.Albumid.ToString();
                    EditTitle.Text = datainfo.Title;
                    EditAlbumArtistList.SelectedValue = datainfo.ArtistId.ToString();
                    EditReleaseYear.Text = datainfo.ReleaseYear.ToString();
                    EditReleaseLabel.Text =
                        datainfo.ReleaseLabel == null ? "" : datainfo.ReleaseLabel;
                }
            }
            );

=======
=======
>>>>>>> 597c2c187e8c192348c55bca9bdbae0d87436087
=======
>>>>>>> 597c2c187e8c192348c55bca9bdbae0d87436087
            AlbumControl sysmgr = new AlbumControl();
            Album datainfo = sysmgr.Album_Get(int.Parse(albumid));
            if (datainfo == null)
            {
                //clear the controls
                //throw an exception
            }
            else
            {
                EditAlbumID.Text = datainfo.Albumid.ToString();
                EditTitle.Text = datainfo.Title;
                EditAlbumArtistList.SelectedValue = datainfo.ArtistId.ToString();
                EditReleaseYear.Text = datainfo.ReleaseYear.ToString();
                EditReleaseLabel.Text =
                    datainfo.ReleaseLabel == null ? "" : datainfo.ReleaseLabel;
            }
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> 84ad18ad5f308d10caf570dca1653c3326a6222e
=======
>>>>>>> 597c2c187e8c192348c55bca9bdbae0d87436087
=======
>>>>>>> 597c2c187e8c192348c55bca9bdbae0d87436087
        }
    }
}