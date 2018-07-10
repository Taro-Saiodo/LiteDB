﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace LiteDB.Engine
{
    /// <summary>
    /// Interface to read current or old datafile structure - Used to shirnk/upgrade datafile from old LiteDB versions
    /// </summary>
    interface IFileReader
    {
        DateTime CreationTime { get; }
        uint CommitCounter { get; }
        DateTime LastCommit { get; }
        int UserVersion { get; }

        IEnumerable<string> GetCollections();
        IEnumerable<IndexInfo> GetIndexes();
        IEnumerable<BsonDocument> GetDocuments(IndexInfo index);
    }
}