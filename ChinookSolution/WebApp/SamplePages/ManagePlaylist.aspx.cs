﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

#region Additonal Namespaces
using ChinookSystem.BLL;
using ChinookSystem.Data.POCOs;
using DMIT2018Common.UserControls;

#endregion

namespace Jan2018DemoWebsite.SamplePages
{
    public partial class ManagePlaylist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TracksSelectionList.DataSource = null;
        }

        protected void CheckForException(object sender, ObjectDataSourceStatusEventArgs e)
        {
            MessageUserControl.HandleDataBoundException(e);
        }

        protected void ArtistFetch_Click(object sender, EventArgs e)
        {
            
            if(string.IsNullOrEmpty(ArtistName.Text))
            {
                MessageUserControl.ShowInfo("Missing Data","Enter the partial artist name");
            }
            else
            {
                MessageUserControl.TryRun(() =>
                {
                    SearchArg.Text = ArtistName.Text;
                    TracksBy.Text = "Artist";
                    TracksSelectionList.DataBind();

                },"Track Search", "Select from the following list to add to your playlist");
            }

          }

        protected void MediaTypeFetch_Click(object sender, EventArgs e)
        {

         
                MessageUserControl.TryRun(() =>
                {
                    SearchArg.Text = MediaTypeDDL.SelectedValue;
                    TracksBy.Text = "MediaType";
                    TracksSelectionList.DataBind();

                }, "Track Search", "Select from the following list to add to your playlist");
            

        }

        protected void GenreFetch_Click(object sender, EventArgs e)
        {

            MessageUserControl.TryRun(() =>
            {
                SearchArg.Text = GenreDDL.SelectedValue;
                TracksBy.Text = "Genre";
                TracksSelectionList.DataBind();

            }, "Track Search", "Select from the following list to add to your playlist");


        }

        protected void AlbumFetch_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(AlbumTitle.Text))
            {
                MessageUserControl.ShowInfo("Missing Data", "Enter the partial Album name");
            }
            else
            {
                MessageUserControl.TryRun(() =>
                {
                    SearchArg.Text = AlbumTitle.Text;
                    TracksBy.Text = "Album";
                    TracksSelectionList.DataBind();

                }, "Track Search", "Select from the following list to add to your playlist");
            }

        }

        protected void PlayListFetch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PlaylistName.Text))
            {
                MessageUserControl.ShowInfo("Required Data","Play list name is required to fetch a play list");

            }
            else
            {
                string playlistname = PlaylistName.Text;
                string username = "HansenB";
                MessageUserControl.TryRun(()  =>
                {
                    PlaylistTracksController  sysmgr= new PlaylistTracksController();
                    List<UserPlaylistTrack> datainfo = sysmgr.List_TracksForPlaylist(playlistname, username);
                    PlayList.DataSource = datainfo;
                    PlayList.DataBind();

                },"playlist tracks" , "see current tracks on playlist below");

            }
 
        }

        protected void MoveDown_Click(object sender, EventArgs e)
        {
            //code to go here

            List<string> reasons = new List<string>();
            if(PlayList.Rows.Count==0)
            {
                reasons.Add ("there is no playlist presend");
            }
            if (string.IsNullOrEmpty(PlaylistName.Text))
            {
                reasons.Add("you must have playlist name");
            }


            int trackid = 0;
            int tracknumber = 0;
            int rowseleted = 0;
            CheckBox playlistselection = null;
            for (int i = 0; i < PlayList.Rows.Count; i++)
            {
                playlistselection = PlayList.Rows[i].FindControl("selectd") as CheckBox;

                if(playlistselection.Checked)
                {
                    rowseleted++;
                    trackid = int.Parse((PlayList.Rows[i].FindControl("trackid") as Label).Text);
                    tracknumber = int.Parse((PlayList.Rows[i].FindControl("tracknumber") as Label).Text);
                }
            }
            if(rowseleted !=1)
            {
                reasons.Add("select only one track to move");
            }
            if (tracknumber == PlayList.Rows.Count)
            {
                reasons.Add("first track number is moved  up");
            }
            if(reasons.Count==0)
            {
                MoveTrack(trackid, tracknumber, "up");
            }
            else
            {
                MessageUserControl.TryRun(() => throw new BusinessRuleException("track move", reasons));
            }

 
        }

        protected void MoveUp_Click(object sender, EventArgs e)
        {
            //code to go here
 
        }


        protected void MoveTrack(int trackid, int tracknumber, string direction)
        {
            //call BLL to move track
            MessageUserControl.TryRun(() => {
                PlaylistTracksController sysmgr = new PlaylistTracksController(); sysmgr.MoveTrack("HansenB", PlaylistName.Text, trackid, tracknumber, direction);
                List<UserPlaylistTrack> datainfo = sysmgr.List_TracksForPlaylist(PlaylistName.Text, "HansenB");
                PlayList.DataSource = datainfo;
                PlayList.DataBind();

            }, "Success", "track has been moved");


            
        }


        protected void DeleteTrack_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(PlaylistName.Text))
            {
                MessageUserControl.ShowInfo("Required data", "playlist name is required to add a track");
            }
            else
            {
                if(PlayList.Rows.Count==0)
                {
                    MessageUserControl.ShowInfo("required data", "no playlist is available review you playlist");
                }

                else
                {
                    List<int> tracktodelete = new List<int>();
                    int rowselectd = 0;
                    CheckBox playlistselection = null;
                    for (int i = 0; i <= PlayList.Rows.Count; i++)
                    {
                        playlistselection = PlayList.Rows[i].FindControl("selectd") as CheckBox;

                        if (playlistselection.Checked)
                        {
                            rowselectd++;
                            tracktodelete.Add (int.Parse((PlayList.Rows[i].FindControl("trackid") as Label).Text));
                            
                        }
                       
                    }
                    if (rowselectd==0)
                    {
                        MessageUserControl.ShowInfo("Requried Data", "you must select at least one track to remove.");
                    }
                    
                    
                    else
                        {
                            MessageUserControl.TryRun(() =>
                            {
                                PlaylistTracksController sysmgr = new PlaylistTracksController();
                                sysmgr.DeleteTracks("HansenB",PlaylistName.Text,tracktodelete);
                                List<UserPlaylistTrack> datainfo = sysmgr.List_TracksForPlaylist(PlaylistName.Text,"HansenB");
                                PlayList.DataSource = datainfo;
                                PlayList.DataBind();

                            }
                          , "Adding a Track", "Track has been added to the playlist");
                        }
                }
            }
 
        }

        protected void TracksSelectionList_ItemCommand(object sender, 
            ListViewCommandEventArgs e)
        {
            if (string.IsNullOrEmpty(PlaylistName.Text))
            {
                MessageUserControl.ShowInfo("Required data", "play list name is required to add a track");
            }
            else
            {
                string playlistname = PlaylistName.Text;

                string username = "HansenB";
                int trackid = int.Parse(e.CommandArgument.ToString());

                MessageUserControl.TryRun(() =>
                {
                    PlaylistTracksController sysmgr = new PlaylistTracksController();
                    sysmgr.Add_TrackToPLaylist(playlistname, username, trackid);
                    List<UserPlaylistTrack> datainfo = sysmgr.List_TracksForPlaylist(playlistname, username);

                    PlayList.DataSource = datainfo;
                    PlayList.DataBind();

                }
                ,"Adding a Track", "Track has been added to the playlist");
            }
            
        }

    }
}