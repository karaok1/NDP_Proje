﻿/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2014-2015 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 3 - Proje Ödevi
**				ÖĞRENCİ ADI............: Abdullah Akçam
**				ÖĞRENCİ NUMARASI.......: g140910076
**                         DERSİN ALINDIĞI GRUP...: 2. Öğretim A
****************************************************************************/

namespace NDP_Proje.UrunTurleri
{
    public class Bayan : Urun
    {
        public string TurIsmi => "Bayan";

        public Bayan()
        {
            
        }
        
        public Bayan(int depoda, int rafta)
        {
            Stok = new Stok(depoda, rafta);
        }
    }
}