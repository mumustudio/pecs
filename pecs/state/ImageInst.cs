using System;
using System.Collections.Generic;
using System.Drawing;

namespace pecs.state
{
    public class ImageModel
    {
        public String title;
        public Image image;
        public bool selected = false;
        public bool tempSelect = false;

        public ImageModel(Image im, String title)
        {
            this.image = im;
            this.title = title;
        }
    }

    public static class ImageInst
    {
        public static List<ImageModel> imageList = new List<ImageModel>();
    }
}