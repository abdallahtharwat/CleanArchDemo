﻿using CleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Commands.ProductImages
{
    public class EditProductImageCommand : ProductImageCommand
    {
        public EditProductImageCommand(ProductImage productImages)
        {
            ProductImage = productImages;
        }
    }
}
