﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.ValueTuple;

namespace eBookManager.Engine
{
    public class DocumentEngine
    {
        public (DateTime dateCreated, DateTime dateLastAccessed, string fileName, string fileExtension, long fileLength, bool error)
            GetFileProperites (string filePath)
        {
            //tuple 초기화
            var returnTuple = (created: DateTime.MinValue,
                lastDateAccessed: DateTime.MinValue, name: "", ext: "", fileSize: 0L, error: false);

            try
            {
                FileInfo fi = new FileInfo(filePath);
                fi.Refresh();
                returnTuple = (fi.CreationTime, fi.LastAccessTime, fi.Name, fi.Extension, fi.Length, false);
            }
            catch
            {
                returnTuple.error = true;
            }
            return returnTuple;
        }
    }
}
