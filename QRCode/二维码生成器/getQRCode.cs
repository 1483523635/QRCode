using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThoughtWorks.QRCode.Codec;

namespace 二维码生成器
{
    /// <summary>
    /// 生成二维码的类
    /// </summary>
   public  class getQRCode
    {
       /// <summary>
       /// 内容
       /// </summary>
        private string content;
       /// <summary>
       /// 编码方式
       /// </summary>
        private string encodeing;
       /// <summary>
       /// 容错级别
       /// </summary>
        private string level;
       /// <summary>
       /// 版本号
       /// </summary>
        private int version;
       /// <summary>
       /// 图片尺寸
       /// </summary>
        private int size;

       /// <summary>
       /// 简单的二维码生成器
       /// </summary>
       /// <param name="text">需要的内容</param>
       /// <returns>二维码图片</returns>
        public Image  simpleQRCode(string text)
        {
            QRCodeEncoder encoder=new QRCodeEncoder();
            encoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.L;
            encoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
            encoder.QRCodeVersion = 4;
            encoder.QRCodeScale = 4;
            Image image = encoder.Encode(text);
            return image;
        }
    }
}
