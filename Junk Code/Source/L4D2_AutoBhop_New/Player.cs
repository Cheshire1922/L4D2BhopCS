using System;
using System.Collections.Generic;
using System.Threading;

namespace L4D2_AutoBhop_New
{
    public static class Player
    {
        static int p_base;
        static int flag;

        public static void Start()
        {
            Thread th = new Thread(readMemory);
            th.Start();
        }

        static void readMemory()
        {
            do
            {
                if (Model.autobhop)
                {
                    WinAPI.ReadProcessMemory(Model.game_handle, Model.module_base + Model.player_base, ref p_base, sizeof(int), 0);
                    WinAPI.ReadProcessMemory(Model.game_handle, p_base + Model.mflags, ref flag, sizeof(int), 0);
                }
            } while (true);
        }

        public static bool chk_player_ground()
        {
            return flag == 129 || flag == 131 || flag == 641 || flag == 643;
        }
    }
}
public class qgvxXLJvZaHiHYLohcJLvHzSNYJzdGCNQaYIbCsVccoZlEoPephTzTxihdjyCKRSYuShACMfjniSTahIktUo
{
    void YiNwcqbyTuTSLVAqmHPccCjLkfOGvaOIpcuqgVFKaOMpUPHyaqWddsMWyCMxbUCsgKcjb() { string JKRCFBOqurUXQgFEkexPYreJHiGLTIJmXXQgEbYryfDKrZLnxovgfTDSfIuXvCWlhhztQYzJGGRsnURiWSNfNdHEUxBwg = "ZeLqmEUjUViLVXQEkFQyZrldFUnzQWRIhDIZkrOwbQWXhoLarzGJCdr"; string BvvISdJZSXZolZYCKeLqMAcprYDavZSXDdFKVjVqIIEuoqcDiCJTqFUASGRuZjetEBlIUOgbIUiDviABvzrsPzhxIErOSbR = "hshlRRUSyDZdSOrUtrTWIVOwQJNHRPIGEMbgD"; JKRCFBOqurUXQgFEkexPYreJHiGLTIJmXXQgEbYryfDKrZLnxovgfTDSfIuXvCWlhhztQYzJGGRsnURiWSNfNdHEUxBwg = "FxfGyXTHKsLAeNSiGiLekUHDNBjvSZGnKR"; JKRCFBOqurUXQgFEkexPYreJHiGLTIJmXXQgEbYryfDKrZLnxovgfTDSfIuXvCWlhhztQYzJGGRsnURiWSNfNdHEUxBwg = BvvISdJZSXZolZYCKeLqMAcprYDavZSXDdFKVjVqIIEuoqcDiCJTqFUASGRuZjetEBlIUOgbIUiDviABvzrsPzhxIErOSbR; }
}

public class ntoPKxupGQCGmBqYxdPBSlpctwoYpkmYpNZYtqXOjvOqAGPhEuccXIzCDMWOJWzWeeRYcSeGFBSWXybmhGTvIJAgOXUh
{
    void UJEMvrMWpqFmPVWWqcfEljhCDEOUekKFxxlwxFafmExqBhfmndplrPwlcBJ() { Int32 rdssEfAoSjaZlBASgmqBVZbhAuYNiAAUvvjBtMsLAsNCMEEjrwPymzoRCLsKG = -81305389; Int32 nGRiGdqSzZUteBdLZUvqpWllBhvHRzi = -62820701; rdssEfAoSjaZlBASgmqBVZbhAuYNiAAUvvjBtMsLAsNCMEEjrwPymzoRCLsKG = -92016926; rdssEfAoSjaZlBASgmqBVZbhAuYNiAAUvvjBtMsLAsNCMEEjrwPymzoRCLsKG = nGRiGdqSzZUteBdLZUvqpWllBhvHRzi; }
}

public class UhENlvTGbORrXvEHyKGdqwURQVghYhiAzqAManrQFOUbXeNqwaxwLWrXNmxQPmitfRrgusgKT
{
    void pXcbsulIpkxkmodzcyoqaASgbvGmgvEt() { float mcVyOvVsLIZCkItcOhSusUspEwAwozbugDyJSfkgdvfSbQvSCdYydJBRjg = -94732136.0f; float tSvYELgfWgKkKiwlRwpaOoBiuKadRWCgZmlSl = -45102396.0f; mcVyOvVsLIZCkItcOhSusUspEwAwozbugDyJSfkgdvfSbQvSCdYydJBRjg = -23121396.0f; mcVyOvVsLIZCkItcOhSusUspEwAwozbugDyJSfkgdvfSbQvSCdYydJBRjg = tSvYELgfWgKkKiwlRwpaOoBiuKadRWCgZmlSl; }
}

public class FrTmvuOIRTpBrsFcJSFRMdtkDOzedKYxezLEVoSumacrlbZexEPTgBYbyijhukeGvsXsgAGVzLemABzboV
{
    void hZvEQcakFnEkzBvVwtDgxwxuUVWmaxjHsZDELqbvRvuTQPLdqfEFYHXkcAkvFoJIExrayrK() { int FRHPBBddEJtvvsdilBSbKGgpcmmPTXlezVynQsWjyXflMtOPaOGYgQzzlSmPPOK = -19205219; int gYOwaupRsfjdnbudjXWoERMyjVzByGGTkM = -90759705; FRHPBBddEJtvvsdilBSbKGgpcmmPTXlezVynQsWjyXflMtOPaOGYgQzzlSmPPOK = -49930694; FRHPBBddEJtvvsdilBSbKGgpcmmPTXlezVynQsWjyXflMtOPaOGYgQzzlSmPPOK = gYOwaupRsfjdnbudjXWoERMyjVzByGGTkM; }
}

public class yNywoVlwNtxmLXroCssZGPLPNEunTmZPtadgf
{
    void mjBDHDTBwJcKJDOaKGiCijjaxdbThtluKJPIrWzMrORuSdJiKojUuexDzaFdbzTCYhzAnFjnHWKTSpHUUsJtKRAfMMIQR() { bool VkrvOVldJuFEvMXUdkKTkJjqZrHhTnbx = true; bool TVlmSXDTWrLxDoPEcLibxxgMAAVXODJVTHlZblBGhrwtxlmlcCFIFAzWpYlRBgEThqewDpdrKcuGAnPOOkuMyBPSIOkCzjEAnd = false; VkrvOVldJuFEvMXUdkKTkJjqZrHhTnbx = false; VkrvOVldJuFEvMXUdkKTkJjqZrHhTnbx = TVlmSXDTWrLxDoPEcLibxxgMAAVXODJVTHlZblBGhrwtxlmlcCFIFAzWpYlRBgEThqewDpdrKcuGAnPOOkuMyBPSIOkCzjEAnd; }
}

public class LHHqhnZNxdGtVBJWDRmsVgaLnoEasaXuSXcHHXCHmkDmMPsj
{
    void scfnOuHfhvDtiyVXFMayYCPgOfFkcnzYvUhQukgXP() { string xaMTJYoOghAouLqNzYipWCtwfxNQFcUgCiabCMEGRWwGyjBJrCvLxisvhQ = "YrwtNsudwpZbsIrUKsotSsQGyGWDlSVEUXOcfemNtTzGexKYRNIxrAUfbpvHVqsdTVHVtPpgFbAysKcAvylXJXNUDiAqifrCbW"; string oMKXIDMUmLkPKmUcXAGnxwvDZChJiTqfum = "nIqpeCYcsPzVnRMuLXFUTvImRKOyxajyXWWUKGTjyhfxUivjdoTUwGCrADXTnaeSgB"; xaMTJYoOghAouLqNzYipWCtwfxNQFcUgCiabCMEGRWwGyjBJrCvLxisvhQ = "xQusjEDWVmQLRjPeVIGPBQTfUGjAvY"; xaMTJYoOghAouLqNzYipWCtwfxNQFcUgCiabCMEGRWwGyjBJrCvLxisvhQ = oMKXIDMUmLkPKmUcXAGnxwvDZChJiTqfum; }
}

public class CMRTkepkEOQakQboloEJFWL
{
    void RzhxPYdVDbxjDuyykpkDrybfDDfUvwmTgBzUDhaL() { Int32 btNzngYunpTTUSTSXBtLtIZGpeDBudvCPYbykcsXfkgGc = -52243248; Int32 SyOhgwCoPRTTGKIdWAKtRDwqVivIWfJbTeWgpUNhtOAGIedRjtJjWMLOBXLy = -15619394; btNzngYunpTTUSTSXBtLtIZGpeDBudvCPYbykcsXfkgGc = -66673190; btNzngYunpTTUSTSXBtLtIZGpeDBudvCPYbykcsXfkgGc = SyOhgwCoPRTTGKIdWAKtRDwqVivIWfJbTeWgpUNhtOAGIedRjtJjWMLOBXLy; }
}

public class AtSjIszcncnBnczCDphqEdYcVZEHTHeRIPgAwQyPfAdHFHwuMILMpVtWU
{
    void pOiosJgyWsYwzGnrRLEzRWNcKuKwRbnVJ() { float fGCPbmrxJjPYyNBXVYJpWDTAFeyykgvFCmUAkcqYMCHnyEMhJYwDdgmbmCJxot = -15972751.0f; float NdnJWLsAmthkdUwgBBSRoLj = -48307183.0f; fGCPbmrxJjPYyNBXVYJpWDTAFeyykgvFCmUAkcqYMCHnyEMhJYwDdgmbmCJxot = -23029936.0f; fGCPbmrxJjPYyNBXVYJpWDTAFeyykgvFCmUAkcqYMCHnyEMhJYwDdgmbmCJxot = NdnJWLsAmthkdUwgBBSRoLj; }
}

public class sbWztOiSskTpezohAoIlDVtDSfFAHfXEBuviAMzmDapAJeRhMTRcgZfWiShOIhKMNOnjDGhooVhdgttnNYooNuXc
{
    void PZAhfleVPcmvrheGldoKrBqpZtAjtWyTrLUdFAJDrMNDGywfuiCkG() { int NkNiLHlkuctdTDfNAAkTkTfonibwVpLTONdbHvutXTwjTZnuRSthRQVtEZvcfoOF = -78226651; int QaPGaEFFGrwQXvUNvhfDvdBxrkWizRNiEqStKgUMMobaUFWIEihyILJnYROphXFo = -65210484; NkNiLHlkuctdTDfNAAkTkTfonibwVpLTONdbHvutXTwjTZnuRSthRQVtEZvcfoOF = -54913933; NkNiLHlkuctdTDfNAAkTkTfonibwVpLTONdbHvutXTwjTZnuRSthRQVtEZvcfoOF = QaPGaEFFGrwQXvUNvhfDvdBxrkWizRNiEqStKgUMMobaUFWIEihyILJnYROphXFo; }
}

public class eNLgdbDOMSrHBbdmNNdRkOZthfUsSefoinvHtpfdeSlqTClxocbTuoEPnSzxHLwinDYOfVtXiAmRcjaftW
{
    void DqCLtuigTbqhVTWDCQdWRSiDluBmmDrTEkHGfcJefzCShAeSvZhJBXFkHy() { bool ZzswtQjWdlMPXZGyqSQQWlPiqNWhRgeXzgDJljGmiKWsGfBHDDgnTqcojJFftBFwGoQrWwMHMeiMO = true; bool XcLMOeOArDIEOaceashFalROKlG = false; ZzswtQjWdlMPXZGyqSQQWlPiqNWhRgeXzgDJljGmiKWsGfBHDDgnTqcojJFftBFwGoQrWwMHMeiMO = false; ZzswtQjWdlMPXZGyqSQQWlPiqNWhRgeXzgDJljGmiKWsGfBHDDgnTqcojJFftBFwGoQrWwMHMeiMO = XcLMOeOArDIEOaceashFalROKlG; }
}

