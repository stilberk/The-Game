using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpriteAnimation
{
    using Microsoft.Xna.Framework;

    public class MapBoundaries
    {
        private List<Rectangle> mapObj;
        private Rectangle stop1;

        private Rectangle treesP1_1;
        private Rectangle treesP1_2;
    
        private Rectangle treesP2_1;
        private Rectangle treesP2_2;
        private Rectangle treesP2_3;
        private Rectangle treesP3;
        private Rectangle treesP4;
        private Rectangle treesP5;
        private Rectangle treesP6;
        private Rectangle treesP7;
        private Rectangle treesP8;
        private Rectangle treesP9;

        private Rectangle cactusP1_1;
        private Rectangle cactusP1_2;
        private Rectangle cactusP2;
        private Rectangle cactusP3_1;
        private Rectangle cactusP3_2;
        private Rectangle cactusP4_1;
        private Rectangle cactusP4_2;
        private Rectangle cactusP4_3;
        private Rectangle cactusP4_4;
        private Rectangle cactusP5_1;
        private Rectangle cactusP5_2;
        private Rectangle cactusP6;
        private Rectangle cactusP7;
        private Rectangle cactusP8;
        private Rectangle cactusP9;
        private Rectangle cactusP10;
        private Rectangle cactusP11;
        private Rectangle cactusP12;
        private Rectangle cactusP13;
        private Rectangle cactusP14;
        private Rectangle cactusP15;
        private Rectangle cactusP16_1;
        private Rectangle cactusP16_2;
        private Rectangle cactusP17;


        public MapBoundaries()
        {
            this.mapObj = new List<Rectangle>();



            this.treesP1_1 = new Rectangle(0, 0, 294, 140);
            this.mapObj.Add(this.treesP1_1);
            this.treesP1_2 = new Rectangle(116, 132, 133, 34);
            this.mapObj.Add(this.treesP1_2);
           

            this.treesP2_1 = new Rectangle(345, 0, 673, 144);
            this.mapObj.Add(this.treesP2_1);
            this.treesP2_2 = new Rectangle(375, 132, 130, 32);
            this.mapObj.Add(this.treesP2_2);
            this.treesP2_3 = new Rectangle(724, 96, 303, 70);
            this.mapObj.Add(this.treesP2_3);

            this.treesP3 = new Rectangle(925, 321, 105, 79);
            this.mapObj.Add(this.treesP3);

            this.treesP4 = new Rectangle(28, 308, 88, 75);
            this.mapObj.Add(this.treesP4);

            this.treesP5 = new Rectangle(330, 311, 88, 75);
            this.mapObj.Add(this.treesP5);

            this.treesP6 = new Rectangle(752, 497, 88, 75);
            this.mapObj.Add(this.treesP6);

            this.treesP7 = new Rectangle(555, 594, 88, 75);
            this.mapObj.Add(this.treesP7);

            this.treesP8 = new Rectangle(58, 673, 88, 75);
            this.mapObj.Add(this.treesP8);

            this.treesP9 = new Rectangle(924, 752, 88, 75);
            this.mapObj.Add(this.treesP9);

            this.cactusP1_1 = new Rectangle(148, 168, 65, 59);
            this.mapObj.Add(this.cactusP1_1);
            this.cactusP1_2 = new Rectangle(179, 224, 7, 37);
            this.mapObj.Add(this.cactusP1_2);

            this.cactusP2 = new Rectangle(0, 290, 136, 59);
            this.mapObj.Add(this.cactusP2);

            this.cactusP3_1 = new Rectangle(390, 294, 30, 30);
            this.mapObj.Add(this.cactusP3_1);
            this.cactusP3_2 = new Rectangle(340, 260, 36, 59);
            this.mapObj.Add(this.cactusP3_2);

            this.cactusP4_1 = new Rectangle(834, 304, 13, 63);
            this.mapObj.Add(this.cactusP4_1);
            this.cactusP4_2 = new Rectangle(861, 342, 13, 63);
            this.mapObj.Add(this.cactusP4_2);
            this.cactusP4_3 = new Rectangle(899, 306, 13, 63);
            this.mapObj.Add(this.cactusP4_3);
            this.cactusP4_4 = new Rectangle(932, 276, 105, 44);
            this.mapObj.Add(this.cactusP4_4);

            this.cactusP5_1 = new Rectangle(241, 501, 44, 129);
            this.mapObj.Add(this.cactusP5_1);
            this.cactusP5_2 = new Rectangle(289, 536, 26, 59);
            this.mapObj.Add(this.cactusP5_2);

            this.cactusP6 = new Rectangle(0, 660, 69, 192);
            this.mapObj.Add(this.cactusP6);

            this.cactusP7 = new Rectangle(868, 680, 163, 80);
            this.mapObj.Add(this.cactusP7);

            this.cactusP8 = new Rectangle(582, 324, 5, 35);
            this.mapObj.Add(this.cactusP8);
            this.cactusP9 = new Rectangle(644, 325, 5, 35);
            this.mapObj.Add(this.cactusP9);
            this.cactusP10 = new Rectangle(98, 512, 5, 35);
            this.mapObj.Add(this.cactusP10);
            this.cactusP11 = new Rectangle(131, 485, 5, 35);
            this.mapObj.Add(this.cactusP11);
            this.cactusP12 = new Rectangle(387, 645, 5, 35);
            this.mapObj.Add(this.cactusP12);
            this.cactusP13 = new Rectangle(452, 663, 5, 35);
            this.mapObj.Add(this.cactusP13);
            this.cactusP14 = new Rectangle(149, 850, 5, 35);
            this.mapObj.Add(this.cactusP14);
            this.cactusP15 = new Rectangle(180, 836, 5, 35);
            this.mapObj.Add(this.cactusP15);

            this.cactusP16_1 = new Rectangle(452, 900, 37, 134);
            this.mapObj.Add(this.cactusP16_1);
            this.cactusP16_2 = new Rectangle(484, 866, 5, 35);
            this.mapObj.Add(this.cactusP16_2);

            this.cactusP17 = new Rectangle(580, 902, 37, 152);
            this.mapObj.Add(this.cactusP17);

            this.stop1 = new Rectangle(513, 882, 62, 52);
            this.mapObj.Add(this.stop1);
        }


        public List<Rectangle> MapObjects
        {
            get
            {
                return this.mapObj;
            }
        }
    }
}
