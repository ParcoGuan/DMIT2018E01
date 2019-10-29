﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using ChinookSystem.Data.Entities;
using ChinookSystem.Data.POCOs;
using ChinookSystem.DAL;
using System.ComponentModel;
using DMIT2018Common.UserControls;
#endregion

namespace ChinookSystem.BLL
{
    public class PlaylistTracksController
    {
        public List<UserPlaylistTrack> List_TracksForPlaylist(
            string playlistname, string username)
        {
            using (var context = new ChinookContext())
            {

                var results = (from x in context.Playlists where x.UserName.Equals(username) && x.Name.Equals(playlistname)
                               select x).FirstOrDefault();


                if(results ==null)
                {
                    return null;
                }
                else
                {
                    var theTracks = from x in context.PlaylistTracks
                                    where x.PlaylistId.Equals(results.PlaylistId)
                                    orderby x.TrackNumber
                                    select new UserPlaylistTrack
                                    {
                                        TrackID = x.TrackId,
                                        TrackNumber = x.TrackNumber,
                                        TrackName = x.Track.Name,
                                        Milliseconds = x.Track.Milliseconds,
                                        UnitPrice = x.Track.UnitPrice
                                    };
                }
                return null;
            }
        }//eom
        public void Add_TrackToPLaylist(string playlistname, string username, int trackid)
        {
            using (var context = new ChinookContext())
            {
                List<string> reasons = new List<string>();
                PlaylistTrack  newtrack = null;
                int tracknumber = 0;



                Playlist exists = context.Playlists.Where(x => x.UserName.Equals(username, StringComparison.OrdinalIgnoreCase) &&
                x.Name.Equals(playlistname, StringComparison.OrdinalIgnoreCase)).Select(x => x).FirstOrDefault();

                // Playlist exists =( from x in context.Playlists wherex => x.UserName.Equals(username, StringComparison.OrdinalIgnoreCase &&
                //x.Name.Equals(playlistname, StringComparison.OrdinalIgnoreCase) select x).FirstOrDefault();

                if (exists == null)
                {
                    exists = new Playlist();
                    exists.Name = playlistname;
                    exists.UserName = username;
                    exists = context.Playlists.Add(exists);
                    tracknumber = 1;
                }
                else
                {
                    newtrack = exists.PlaylistTracks.SingleOrDefault(x => x.TrackId == trackid);
                    if(newtrack ==null)
                    {
                        tracknumber = exists.PlaylistTracks.Count() + 1;
                    }
                    else
                    {
                        reasons.Add("Track already exists on playlist");
                    }
                }

                if(reasons.Count()>0)
                {
                    throw new BusinessRuleException("adding track to playlist", reasons);
                }
                else
                {
                    newtrack = new PlaylistTrack();
                    newtrack.TrackId = trackid;
                    newtrack.TrackNumber = tracknumber;

                    exists.PlaylistTracks.Add(newtrack);
                    context.SaveChanges();
                }


            }
        }//eom
        public void MoveTrack(string username, string playlistname, int trackid, int tracknumber, string direction)
        {
            using (var context = new ChinookContext())
            {
                //code to go here 

            }
        }//eom


        public void DeleteTracks(string username, string playlistname, List<int> trackstodelete)
        {
            using (var context = new ChinookContext())
            {
               //code to go here


            }
        }//eom
    }
}
