﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


    internal static class imageUtil
    {
        public static Image ConverterBytesParaImagem(byte[] dados)
        {
            if (dados == null || dados.Length == 0)
                return null;

            try
            {
                using (var ms = new MemoryStream(dados))
                {
                    return Image.FromStream(ms);
                }
            }
            catch
            {
                return null;
            }
        }
        public static byte[] ConverterImagemParaBytes(Image imagem)
        {
            if (imagem == null)
                return null;

            using (var ms = new MemoryStream())
            {
                imagem.Save(ms, imagem.RawFormat);
                return ms.ToArray();
            }
        }
        
    }

