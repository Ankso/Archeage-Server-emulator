﻿using LocalCommons.Network;

namespace ArcheAge.ArcheAge.Net
{
    public sealed class NP_X2EnterWorldResponsePacket : NetPacket
    {
        /// <summary>
        /// пакет для входа в Лобби
        /// author: NLObP
        /// </summary>
        public NP_X2EnterWorldResponsePacket() : base(05, 0x00)
        {
            /*
            [2]             S>c             0ms.            13:15:07 .431      26.03.14
            -------------------------------------------------------------------------------
             TType: undef   Server: undef   Parse: off (auto)  EnCode: undef (auto)
            ------- 0  1  2  3  4  5  6  7 -  8  9  A  B  C  D  E  F    -------------------
            000000 15 00 DD 01 00 00 00 00 | 00 C1 21 29 AD E2 04 18     ..Ý......Á!)­â..
            000010 9A 32 53 00 00 00 00                                  .
            -------------------------------------------------------------------------------
            Archeage: "X2EnterWorldResponse"             size: 33     prot: undefined
            Addr:  Size:    Type:         Description:     Value:
            0000     2   word          psize             21         | $0015
            0002     2   word          type              477        | $01DD
            0004     2   word          ID                0          | $0000
            0006     2   word          reason            0          | $0000
            0008     1   byte          gm                0          | $00
            0009     4   integer       sc                -1389813311 | $AD2921C1
            000D     2   word          sp                1250       | $04E2
            000F     8   int64         wf                1395825176 | $53329A18
            0017     4   integer       tz                48037896   | $02DD0008
            001B     2   word          pubKeySize        0          | $0000
            001D     2   WideStr[byte] pubKey              ($)
            001F     4   integer??     natAddr           0          | $00000000
                     2   word          natPort                 
            */
            ///15.06.2018 13:40[INFO] - Encode: 2901DD0576764616E6B687EE09C7BD72645CB875FB714111E2FE7DADDDF7C297623300D4A498992C4ED04CA8599D5B425192D5E1D2397A85330E2BD7A8BE7CEAA28C61AD1DAD0941FA5FADD29D5DC683BBD476F9DD08D9F26B4FDA3863EB73AA93F1CAA748B4EA8AE51FE594BB5DB1019BB34DC3BFDFE2F839210774155B4EEE45F8CFE64968D3B0946810595A88D707D523142CCAFA5F9A31E846D39BDB59F3AE94E21FB996663707D7A7774010E0B0815121F1C192623202D2A3734313E3B4845424F4C595653505D6A6764616E7B7875727FED0A0704011E1B1815122F2C292623303D3A3744414E4B4855525F5C596663606D6A7774717E7B0805020F0C191613101D2A2724212E3B3835323F4C494643405D5A5754516E6B6865727F7C797704110E110F5E6EB4FA0
            ///15.06.2018 13:40[INFO] - Decode: 2901DD05D3000000000000B92E307AE2046C46A45A000000004CFFFFFF0401040100040000ECDD39AB65C9FD7F6B9DD437A5D236754E2AA5C3CEBBB699BFAD4BD0CE734FAF2E5A62099B39B6A9591326CE91631F6B8E8FD49C884D5F5415A30AE3B1DB46F935BBA817DD77F6885E62A2E8F759270B5BB7DDCCE49212235D984932BFD80189F8B3806AB9B1281B9935B5577136DF09693CA9353CE2A7DFCEBC462BC1C4E97F0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000010001A074B73E4A95
            ////0x01 0x0000_X2EnterWorldPacket
            ///ns.WriteHex("00000095FF3C1EE2042226EE5200000000");
            //ns.WriteHex(
            //"2901DD05FB76" - в мир
            //"4616E6B68711E9A954726491ACEFFA714111E2FE7DADDDF7C297623300D4A4A996130EA59E95CEFAF1CE4AFBD9CFAF8A1102A1C90798F036AD15C4BC06A9484CFF41139E57440975AD3639A38B8AC078C6E5B9E5687C1E083E1EF0215A61A2B09DFE5230569A9828D9BC49415CC36656769DD16F042DB4F89C7744B6FDAE78FAEFEF69781E83BA54C5C21648C4E6BA123FDED88E8AC2DE0F841132A2A048C996663707D7A7774010E0B0815121F1C192623202D2A3734313E3B4845424F4C595653505D6A6764616E7B7875727FED0A0704011E1B1815122F2C292623303D3A3744414E4B4855525F5C596663606D6A7774717E7B0805020F0C191613101D2A2724212E3B3835323F4C494643405D5A5754516E6B6865727F7C797704110E1D21CE5CA6AC3");
            ns.WriteHex(
                //"2901DD05D300 0000" + //должно добавиться автоматически
                "000000B92E307AE2046C46A45A000000004CFFFFFF0401040100040000ECDD39AB65C9FD7F6B9DD437A5D236754E2AA5C3CEBBB699BFAD4BD0CE734FAF2E5A62099B39B6A9591326CE91631F6B8E8FD49C884D5F5415A30AE3B1DB46F935BBA817DD77F6885E62A2E8F759270B5BB7DDCCE49212235D984932BFD80189F8B3806AB9B1281B9935B5577136DF09693CA9353CE2A7DFCEBC462BC1C4E97F0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000010001A074B73E4A95");
                //"2901DD050976" - на корабль
                //"4616E6B687458E340B7264236EEEFA714111E2FE7DADDDF7C297623300D4A4A996130EA59E95CEFAF1CE4AFBD9CFAF8A1102A1C90798F036AD15C4BC06A9484CFF41139E57440975AD3639A38B8AC078C6E5B9E5687C1E083E1EF0215A61A2B09DFE5230569A9828D9BC49415CC36656769DD16F042DB4F89C7744B6FDAE78FAEFEF69781E83BA54C5C21648C4E6BA123FDED88E8AC2DE0F841132A2A048C996663707D7A7774010E0B0815121F1C192623202D2A3734313E3B4845424F4C595653505D6A6764616E7B7875727FED0A0704011E1B1815122F2C292623303D3A3744414E4B4855525F5C596663606D6A7774717E7B0805020F0C191613101D2A2724212E3B3835323F4C494643405D5A5754516E6B6865727F7C797704110E1D21CE5CAFDFE");
                //"2901DD055576" +
                //"4616E6B68742275896726415C774FB714111E2FE7DADDDF7C297623300D4A498992C4ED04CA8599D5B425192D5E1D2397A85330E2BD7A8BE7CEAA28C61AD1DAD0941FA5FADD29D5DC683BBD476F9DD08D9F26B4FDA3863EB73AA93F1CAA748B4EA8AE51FE594BB5DB1019BB34DC3BFDFE2F839210774155B4EEE45F8CFE64968D3B0946810595A88D707D523142CCAFA5F9A31E846D39BDB59F3AE94E21FB996663707D7A7774010E0B0815121F1C192623202D2A3734313E3B4845424F4C595653505D6A6764616E7B7875727FED0A0704011E1B1815122F2C292623303D3A3744414E4B4855525F5C596663606D6A7774717E7B0805020F0C191613101D2A2724212E3B3835323F4C494643405D5A5754516E6B6865727F7C797704110E110F5E6EBF33E");


            ////расшифрованные данные из снифа пакета
            //ushort reason = 0;
            //byte gm = 0;
            //uint sc = 0xD7237083;
            //ushort sp = 0x04E2;
            //long wf = 0x5B2D856D;
            //uint tz = 0xFFFFFF4C;
            //ushort pubKeySize = 0x104;
            //const string msg = "00040000BBC0E9659E21640C4D689287322A627C63B8FD9EEDAF0C3999D14079393F023B1D6B032D574F2F787C814D90D137DAFD93E5577EDE35E1696A40B0DC031FB1D333E038A15163D278615FEFB9275D9FBD5B99E77F6890D8DA04F226267FCDC487E1A1DCAEB23A13399699B3617BF59C9DF85A81519C5093D61C5F44B8045FEEE90000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000010001";
            //byte[] pubKey = Utility.StringToByteArray(msg);
            //uint natAddr = 0x55AD5C85;
            //ushort natPort = 0xD7DC;

            //ns.Write((ushort)0x00); //type
            //ns.Write((ushort)reason); //reason
            //ns.Write((byte)gm);   //gm
            //ns.Write((uint)sc); //sc
            //ns.Write((ushort)sp); //sp
            ////ns.Write(wf, 0, 8); //wf 8 байт
            //ns.Write((long)wf); //wf
            //ns.Write((uint)tz); //tz
            //ns.Write((ushort)pubKeySize); //pubKeySize
            //ns.Write(pubKey, 0);  //pubKey 260 байт
            //ns.Write((uint)natAddr); //natAddr
            //ns.Write((ushort)natPort); //natPort
        }
    }
}