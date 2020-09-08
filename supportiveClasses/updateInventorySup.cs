using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace InventorySystem.supportiveClasses
{

    class updateInventorySup
    {
        Image sndImg01;
        Image sndImg02;
        Image sndImg03;
        Image sndImg04;
        Image sndImg05;
        Image sndImg06;

        List<Image> images = new List<Image>();

        private byte[] Image01;
        private byte[] Image02;
        private byte[] Image03;
        private byte[] Image04;
        private byte[] Image05;
        private byte[] Image06;


        private int nwcnt;
        public Boolean validate;
        private int ID;

        public updateInventorySup()
        {
            sndImg01 = null;
            sndImg02 = null;
            sndImg03 = null;
            sndImg04 = null;
            sndImg05 = null;
            sndImg06 = null;


            Image01 = null;
            Image02 = null;
            Image03 = null;
            Image04 = null;
            Image05 = null;
            Image06 = null;
        }

        private void checkValues()
        {
            SqlConnection con = Connect.conn();
            SqlCommand cmd;
            int execute = 0;
            con.Open();

            if (nwcnt == 6)
            {
                String sql = "insert into InvtEventImages(packid,img1,img2,img3,img4,img5,img6) Values(@id,@img1,@img2,@img3,@img4,@img5,@img6)";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@id", System.Data.SqlDbType.Int);
                cmd.Parameters.Add("@img1", System.Data.SqlDbType.Image);
                cmd.Parameters.Add("@img2", System.Data.SqlDbType.Image);
                cmd.Parameters.Add("@img3", System.Data.SqlDbType.Image);
                cmd.Parameters.Add("@img4", System.Data.SqlDbType.Image);
                cmd.Parameters.Add("@img5", System.Data.SqlDbType.Image);
                cmd.Parameters.Add("@img6", System.Data.SqlDbType.Image);

                cmd.Parameters["@id"].Value = ID;
                cmd.Parameters["@img1"].Value = Image01;
                cmd.Parameters["@img2"].Value = Image02;
                cmd.Parameters["@img3"].Value = Image03;
                cmd.Parameters["@img4"].Value = Image04;
                cmd.Parameters["@img5"].Value = Image05;
                cmd.Parameters["@img6"].Value = Image06;

                execute = cmd.ExecuteNonQuery();
                con.Close();

                if (execute == 1)
                {
                    validate = true;
                }
                else
                {
                    validate = false;

                }
            }
            else if (nwcnt == 5)
            {
                String sql = "insert into InvtEventImages(packid,img1,img2,img3,img4,img5) Values(@id,@img1,@img2,@img3,@img4,@img5)";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@id", System.Data.SqlDbType.Int);
                cmd.Parameters.Add("@img1", System.Data.SqlDbType.Image);
                cmd.Parameters.Add("@img2", System.Data.SqlDbType.Image);
                cmd.Parameters.Add("@img3", System.Data.SqlDbType.Image);
                cmd.Parameters.Add("@img4", System.Data.SqlDbType.Image);
                cmd.Parameters.Add("@img5", System.Data.SqlDbType.Image);

                cmd.Parameters["@id"].Value = ID;
                cmd.Parameters["@img1"].Value = Image01;
                cmd.Parameters["@img2"].Value = Image02;
                cmd.Parameters["@img3"].Value = Image03;
                cmd.Parameters["@img4"].Value = Image04;
                cmd.Parameters["@img5"].Value = Image05;

                execute = cmd.ExecuteNonQuery();
                con.Close();


                if (execute == 1)
                {
                    validate = true;
                }
                else
                {
                    validate = false;

                }
            }
            else if (nwcnt == 4)
            {
                String sql = "insert into InvtEventImages(packid,img1,img2,img3,img4) Values(@id,@img1,@img2,@img3,@img4)";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@id", System.Data.SqlDbType.Int);
                cmd.Parameters.Add("@img1", System.Data.SqlDbType.Image);
                cmd.Parameters.Add("@img2", System.Data.SqlDbType.Image);
                cmd.Parameters.Add("@img3", System.Data.SqlDbType.Image);
                cmd.Parameters.Add("@img4", System.Data.SqlDbType.Image);

                cmd.Parameters["@id"].Value = ID;
                cmd.Parameters["@img1"].Value = Image01;
                cmd.Parameters["@img2"].Value = Image02;
                cmd.Parameters["@img3"].Value = Image03;
                cmd.Parameters["@img4"].Value = Image04;

                execute = cmd.ExecuteNonQuery();
                con.Close();


                if (execute == 1)
                {
                    validate = true;
                }
                else
                {
                    validate = false;

                }
            }
            else if (nwcnt == 3)
            {
                String sql = "insert into InvtEventImages(packid,img1,img2,img3) Values(@id,@img1,@img2,@img3)";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@id", System.Data.SqlDbType.Int);
                cmd.Parameters.Add("@img1", System.Data.SqlDbType.Image);
                cmd.Parameters.Add("@img2", System.Data.SqlDbType.Image);
                cmd.Parameters.Add("@img3", System.Data.SqlDbType.Image);

                cmd.Parameters["@id"].Value = ID;
                cmd.Parameters["@img1"].Value = Image01;
                cmd.Parameters["@img2"].Value = Image02;
                cmd.Parameters["@img3"].Value = Image03;

                execute = cmd.ExecuteNonQuery();
                con.Close();


                if (execute == 1)
                {
                    validate = true;
                }
                else
                {
                    validate = false;

                }
            }
            else if (nwcnt == 2)
            {
                String sql = "insert into InvtEventImages(packid,img1,img2) Values(@id,@img1,@img2)";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@id", System.Data.SqlDbType.Int);
                cmd.Parameters.Add("@img1", System.Data.SqlDbType.Image);
                cmd.Parameters.Add("@img2", System.Data.SqlDbType.Image);

                cmd.Parameters["@id"].Value = ID;
                cmd.Parameters["@img1"].Value = Image01;
                cmd.Parameters["@img2"].Value = Image02;

                execute = cmd.ExecuteNonQuery();
                con.Close();


                if (execute == 1)
                {
                    validate = true;
                }
                else
                {
                    validate = false;

                }
            }
            else if (nwcnt == 1)
            {
                String sql = "insert into InvtEventImages(packid,img1) Values(@id,@img1)";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@id", System.Data.SqlDbType.Int);
                cmd.Parameters.Add("@img1", System.Data.SqlDbType.Image);

                cmd.Parameters["@id"].Value = ID;
                cmd.Parameters["@img1"].Value = Image01;

                execute = cmd.ExecuteNonQuery();
                con.Close();

                if (execute == 1)
                {
                    validate = true;
                }
                else
                {
                    validate = false;

                }
            }
            else
            {

                con.Close();
                validate = false;

            }

        }



        public void nwCnt(Image nw01, Image nw02, Image nw03, Image nw04, Image nw05, Image nw06, int ID)
        {
            Console.WriteLine("Came to other class..........................");
            this.ID = ID;
            nwcnt = 6;

            Console.WriteLine("ID is " + this.ID);

            if (nw01 == null)
            { nwcnt = nwcnt - 1; Console.WriteLine("1 Image NULL"); }
            else
            {
                Console.WriteLine("1 Image Added to LIST");
                images.Add(nw01);
            }
            if (nw02 == null)
            { nwcnt = nwcnt - 1; Console.WriteLine("2 Image NULL"); }
            else
            {
                images.Add(nw02);
            }
            if (nw03 == null)
            { nwcnt = nwcnt - 1; Console.WriteLine("3 Image NULL"); }
            else
            {
                images.Add(nw03);
            }
            if (nw04 == null)
            { nwcnt = nwcnt - 1; Console.WriteLine("4 Image NULL"); }
            else
            {
                images.Add(nw04);
            }
            if (nw05 == null)
            { nwcnt = nwcnt - 1; Console.WriteLine("5 Image NULL"); }
            else
            {
                images.Add(nw05);
            }
            if (nw06 == null)
            { nwcnt = nwcnt - 1; Console.WriteLine("6 Image NULL"); }
            else
            {
                images.Add(nw06);

            }

            Console.WriteLine("Number of Images : " + nwcnt);
            this.converter();
        }


        private void converter()
        {
            Console.WriteLine("Came to Converter");
            if (nwcnt == 6)
            {
                Image01 = ImgToByte(images[0]);
                Image02 = ImgToByte(images[1]);
                Image03 = ImgToByte(images[2]);
                Image04 = ImgToByte(images[3]);
                Image05 = ImgToByte(images[4]);
                Image06 = ImgToByte(images[5]);

                Console.WriteLine("\t \t 6 Images Converted");
                this.checkValues();
            }
            else if (nwcnt == 5)
            {
                Image01 = ImgToByte(images[0]);
                Image02 = ImgToByte(images[1]);
                Image03 = ImgToByte(images[2]);
                Image04 = ImgToByte(images[3]);
                Image05 = ImgToByte(images[4]);

                Console.WriteLine("\t \t 5 Images Converted");
                this.checkValues();

            }
            else if (nwcnt == 4)
            {
                Image01 = ImgToByte(images[0]);
                Image02 = ImgToByte(images[1]);
                Image03 = ImgToByte(images[2]);
                Image04 = ImgToByte(images[3]);

                Console.WriteLine("\t \t 4 Images Converted");
                this.checkValues();

            }
            else if (nwcnt == 3)
            {
                Image01 = ImgToByte(images[0]);
                Image02 = ImgToByte(images[1]);
                Image03 = ImgToByte(images[2]);

                Console.WriteLine("\t \t 3 Images Converted");
                this.checkValues();

            }
            else if (nwcnt == 2)
            {
                Image01 = ImgToByte(images[0]);
                Image02 = ImgToByte(images[1]);

                Console.WriteLine("\t \t 2 Images Converted");
                this.checkValues();

            }
            else if (nwcnt == 1)
            {
                Image01 = ImgToByte(images[0]);

                Console.WriteLine("\t \t 1 Images Converted");
                this.checkValues();

            }
            else
            {

            }
        }


        private byte[] ImgToByte(Image imageIn)
        {
            ImageConverter imageConverter = new ImageConverter();

            byte[] arr = (byte[])imageConverter.ConvertTo(imageIn, typeof(byte[]));
            return arr;

        }


    }
}
