﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Compression.BSA
{
    public abstract class ArchiveStateObject
    {
        public abstract Task<IBSABuilder> MakeBuilder(long size);
    }
}
