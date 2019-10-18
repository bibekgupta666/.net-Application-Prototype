using Model.MediaDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Model.MediaDataSet;

namespace Controller
{
    public class MediaManagerImpl : iMediaManager
    {
        public DataTable CustomSearch(string director, string genre)
        {
            ViewMediaDataTable mediaDataTable = new ViewMediaDataTable();
            ViewMediaTableAdapter mediaTableAdapter = new ViewMediaTableAdapter();

            if (director == "" && genre == "")
            {
                mediaTableAdapter.Fill(mediaDataTable);
            }
            else if (director != "" && genre == "")
            {
                mediaTableAdapter.SearchDirector(mediaDataTable, director);
            }
            else if (director == "" && genre != "")
            {
                mediaTableAdapter.SearchGenre(mediaDataTable, genre);
            }
            else
            {
                mediaTableAdapter.SearchDirectorAndGenre(mediaDataTable, director, genre);
            }
            if(mediaDataTable.Rows.Count == 0)
            {
                mediaDataTable = null;
            }
            return mediaDataTable;
        }

        public DataTable ViewAllMedia()
        {
            ViewMediaDataTable mediaDataTable = new ViewMediaDataTable();
            ViewMediaTableAdapter mediaTableAdapter = new ViewMediaTableAdapter();

            mediaTableAdapter.Fill(mediaDataTable);
            return mediaDataTable;

        }
    }
}
