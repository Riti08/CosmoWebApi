﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Interfaces.IEncription
{
    public interface IEncryption
    {

        public string EncodePasswordToBase64(string password);

        public string DecodeFrom64(string encodedData);

    }
}
