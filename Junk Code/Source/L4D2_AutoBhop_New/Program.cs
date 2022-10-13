using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace L4D2_AutoBhop_New
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Count() == 0)
            {
                MessageBox.Show("Type PlayerBase Value\nUse to cmd : L4D2_AutoBhop_New PlayerBase mFlag");
                Environment.Exit(0);
            }

            Model.player_base = Convert.ToInt32(args[0], 16);
            Model.mflags = Convert.ToInt32(string.IsNullOrEmpty(args[1]) ? "0xF0" : args[1], 16);

            Console.WriteLine("[-] Find Left 4 Dead 2 process...");
            Process gameProcess = Process.GetProcessesByName("left4dead2").First();
            if (gameProcess != null)
            {
                Console.WriteLine("[+] Left 4 Dead 2 found");
                Model.process_handle = gameProcess.MainWindowHandle;
                Model.game_handle = WinAPI.OpenProcess(WinAPI.ProcessAccessFlags.All, false, gameProcess.Id);
                Model.module_base = Util.get_module_base(gameProcess.Id, "client.dll");
                Console.WriteLine(Model.module_base);
                Player.Start();
                AutoBhop.Start();
                Console.WriteLine("Youtube.com/cheshire_osu");
                Console.WriteLine("Discord: Cheshire#1337");
                Console.WriteLine("[+] Process Attached");
                Console.WriteLine();
                Console.WriteLine("[-] F1 : On/Off");
                Console.WriteLine("[-] F2 : Exit ");
                Console.WriteLine();
                Console.WriteLine("[★] Bhop : OFF");

                
                do
                {
                    bool F1_Status = Util.IsKeyDown(System.Windows.Forms.Keys.F1);
                    bool F2_Status = Util.IsKeyDown(System.Windows.Forms.Keys.F2);

                    

                    if (F1_Status && !Model.autobhop)
                    {
                        Model.autobhop = true;

                        Console.SetCursorPosition(0, Console.CursorTop - 1);
                        Util.ClearCurrentConsoleLine();
                        Console.WriteLine("[★] Bhop : ON");
                    }
                    else if (F1_Status && Model.autobhop)
                    {
                        Model.autobhop = false;

                        Console.SetCursorPosition(0, Console.CursorTop - 1);
                        Util.ClearCurrentConsoleLine();
                        Console.WriteLine("[★] AutoBhop : OFF");
                    }

                    if (F2_Status)
                    {
                        Environment.Exit(0);
                    }

                    Thread.Sleep(100);
                } while (true);
            }
            else
                Console.WriteLine("[!] Bhop attach failed. Open L4D2 First");

            Console.WriteLine("[-] Press any Key close program");
            Console.ReadLine();
        }
    }
}

public class qgvxXLJvZaHiHYLohcJLvHzSNYJzdG756475442CNQaYIbCsVccoZlEoPephTzTxihdjyCKRSYuShACMfjniSTahIktUo
{
    void YiNwcqbyTuTSLVAqmHPccCjLkfOGvaOI75643547543456pcuqgVFKaOMpUPHyaqWddsMWyCMxbUCsgKcjb() { string JKRCFBOqurUXQgFEkexPYreJHiGLTIJmXXQgEbYryfDKrZLnxovgfTDSfIuXvCWlhhztQYzJGGRsnURiWSNfNdHEUxBwg = "ZeLqmEUjUViLVXQEkFQyZrldFUnzQWRIhDIZkrOwbQWXhoLarzGJCdr"; string BvvISdJZSXZolZYCKeLqMAcprYDavZSXDdFKVjVqIIEuoqcDiCJTqFUASGRuZjetEBlIUOgbIUiDviABvzrsPzhxIErOSbR = "hshlRRUSyDZdSOrUtrTWIVOwQJNHRPIGEMbgD"; JKRCFBOqurUXQgFEkexPYreJHiGLTIJmXXQgEbYryfDKrZLnxovgfTDSfIuXvCWlhhztQYzJGGRsnURiWSNfNdHEUxBwg = "FxfGyXTHKsLAeNSiGiLekUHDNBjvSZGnKR"; JKRCFBOqurUXQgFEkexPYreJHiGLTIJmXXQgEbYryfDKrZLnxovgfTDSfIuXvCWlhhztQYzJGGRsnURiWSNfNdHEUxBwg = BvvISdJZSXZolZYCKeLqMAcprYDavZSXDdFKVjVqIIEuoqcDiCJTqFUASGRuZjetEBlIUOgbIUiDviABvzrsPzhxIErOSbR; }
}

public class ntoPKxupGQCGmBqYxdPBSlpctwoYpkmYpNZYtqXOjvOqAGPhi96778EuccXIzCDMWOJWzWeeRYcSeGFBSWXybmhGTvIJAgOXUh
{
    void UJEMvrMWpqFmPVWWqcfEljhCDEOUekKFxxlwxF634463afmExqBhfmndplrPwlcBJ() { Int32 rdssEfAoSjaZlBASgmqBVZbhAuYNiAAUvvjBtMsLAsNCMEEjrwPymzoRCLsKG = -81305389; Int32 nGRiGdqSzZUteBdLZUvqpWllBhvHRzi = -62820701; rdssEfAoSjaZlBASgmqBVZbhAuYNiAAUvvjBtMsLAsNCMEEjrwPymzoRCLsKG = -92016926; rdssEfAoSjaZlBASgmqBVZbhAuYNiAAUvvjBtMsLAsNCMEEjrwPymzoRCLsKG = nGRiGdqSzZUteBdLZUvqpWllBhvHRzi; }
}

public class UhENlvTGbOR235235rXvEHyKGdqwURQVghYhiAzqAManrQFOUbXeNqwaxwLWrXNmxQPmitfRrgusgKT
{
    void pXcbsulIpkxkmodzc23543yoqaASgbvGmgvEt() { float mcVyOvVsLIZCkItcOhSusUspEwAwozbugDyJSfkgdvfSbQvSCdYydJBRjg = -94732136.0f; float tSvYELgfWgKkKiwlRwpaOoBiuKadRWCgZmlSl = -45102396.0f; mcVyOvVsLIZCkItcOhSusUspEwAwozbugDyJSfkgdvfSbQvSCdYydJBRjg = -23121396.0f; mcVyOvVsLIZCkItcOhSusUspEwAwozbugDyJSfkgdvfSbQvSCdYydJBRjg = tSvYELgfWgKkKiwlRwpaOoBiuKadRWCgZmlSl; }
}

public class FrTmvuOIRTpBrsFcJSFRMdtkDOzedKYx432645ezLEVoSumacrlbZexEPTgBYbyijhukeGvsXsgAGVzLemABzboV
{
    void hZvEQcakFnEkzBvVwtDgxwxuUVWmaxjHsZDELqbvRvuTQPL3412645dqfEFYHXkcAkvFoJIExrayrK() { int FRHPBBddEJtvvsdilBSbKGgpcmmPTXlezVynQsWjyXflMtOPaOGYgQzzlSmPPOK = -19205219; int gYOwaupRsfjdnbudjXWoERMyjVzByGGTkM = -90759705; FRHPBBddEJtvvsdilBSbKGgpcmmPTXlezVynQsWjyXflMtOPaOGYgQzzlSmPPOK = -49930694; FRHPBBddEJtvvsdilBSbKGgpcmmPTXlezVynQsWjyXflMtOPaOGYgQzzlSmPPOK = gYOwaupRsfjdnbudjXWoERMyjVzByGGTkM; }
}

public class yNywoVlwNtxmLXroCssZGPL7456634PNEunTmZPtadgf
{
    void mjBDHDTBwJcKJDOaKGiCijjaxdbThtluKJPIrWzM76245rORuSdJiKojUuexDzaFdbzTCYhzAnFjnHWKTSpHUUsJtKRAfMMIQR() { bool VkrvOVldJuFEvMXUdkKTkJjqZrHhTnbx = true; bool TVlmSXDTWrLxDoPEcLibxxgMAAVXODJVTHlZblBGhrwtxlmlcCFIFAzWpYlRBgEThqewDpdrKcuGAnPOOkuMyBPSIOkCzjEAnd = false; VkrvOVldJuFEvMXUdkKTkJjqZrHhTnbx = false; VkrvOVldJuFEvMXUdkKTkJjqZrHhTnbx = TVlmSXDTWrLxDoPEcLibxxgMAAVXODJVTHlZblBGhrwtxlmlcCFIFAzWpYlRBgEThqewDpdrKcuGAnPOOkuMyBPSIOkCzjEAnd; }
}

public class LHHqhnZNxdGtVBJWDRmsVgaLnoEasaXuS534345XcHHXCHmkDmMPsj
{
    void scfnOuHfhvDtiyVXFMayYCPgOfFkcnzYvU645hQukgXP() { string xaMTJYoOghAouLqNzYipWCtwfxNQFcUgCiabCMEGRWwGyjBJrCvLxisvhQ = "YrwtNsudwpZbsIrUKsotSsQGyGWDlSVEUXOcfemNtTzGexKYRNIxrAUfbpvHVqsdTVHVtPpgFbAysKcAvylXJXNUDiAqifrCbW"; string oMKXIDMUmLkPKmUcXAGnxwvDZChJiTqfum = "nIqpeCYcsPzVnRMuLXFUTvImRKOyxajyXWWUKGTjyhfxUivjdoTUwGCrADXTnaeSgB"; xaMTJYoOghAouLqNzYipWCtwfxNQFcUgCiabCMEGRWwGyjBJrCvLxisvhQ = "xQusjEDWVmQLRjPeVIGPBQTfUGjAvY"; xaMTJYoOghAouLqNzYipWCtwfxNQFcUgCiabCMEGRWwGyjBJrCvLxisvhQ = oMKXIDMUmLkPKmUcXAGnxwvDZChJiTqfum; }
}

public class CMRTkepkEOQa765kQboloEJFWL
{
    void RzhxPYdVDbxjDuyykpkDry432bfDDfUvwmTgBzUDhaL() { Int32 btNzngYunpTTUSTSXBtLtIZGpeDBudvCPYbykcsXfkgGc = -52243248; Int32 SyOhgwCoPRTTGKIdWAKtRDwqVivIWfJbTeWgpUNhtOAGIedRjtJjWMLOBXLy = -15619394; btNzngYunpTTUSTSXBtLtIZGpeDBudvCPYbykcsXfkgGc = -66673190; btNzngYunpTTUSTSXBtLtIZGpeDBudvCPYbykcsXfkgGc = SyOhgwCoPRTTGKIdWAKtRDwqVivIWfJbTeWgpUNhtOAGIedRjtJjWMLOBXLy; }
}

public class AtSjIszcncnBnczCDphqEdY754cVZEHTHeRIPgAwQyPfAdHFHwuMILMpVtWU
{
    void pOiosJgyWsYwzGnrRLEzRWNcKuKwRbnVJ() { float fGCPbmrxJjPYyNBXVYJpWDTAFeyykgvFCmUAkcqYMCHnyEMhJYwDdgmbmCJxot = -15972751.0f; float NdnJWLsAmthkdUwgBBSRoLj = -48307183.0f; fGCPbmrxJjPYyNBXVYJpWDTAFeyykgvFCmUAkcqYMCHnyEMhJYwDdgmbmCJxot = -23029936.0f; fGCPbmrxJjPYyNBXVYJpWDTAFeyykgvFCmUAkcqYMCHnyEMhJYwDdgmbmCJxot = NdnJWLsAmthkdUwgBBSRoLj; }
}

public class sbWztOiSskTpezohA432oIlDVtDSfFAHfXEBuviAMzmDapAJeRhMTRcgZfWiShOIhKMNOnjDGhooVhdgttnNYooNuXc
{
    void PZAhfleVPcmvrheGldoKrBqpZtAjtWyTrLUdFAJDrMNDGywfuiCkG() { int NkNiLHlkuctdTDfNAAkTkTfonibwVpLTONdbHvutXTwjTZnuRSthRQVtEZvcfoOF = -78226651; int QaPGaEFFGrwQXvUNvhfDvdBxrkWizRNiEqStKgUMMobaUFWIEihyILJnYROphXFo = -65210484; NkNiLHlkuctdTDfNAAkTkTfonibwVpLTONdbHvutXTwjTZnuRSthRQVtEZvcfoOF = -54913933; NkNiLHlkuctdTDfNAAkTkTfonibwVpLTONdbHvutXTwjTZnuRSthRQVtEZvcfoOF = QaPGaEFFGrwQXvUNvhfDvdBxrkWizRNiEqStKgUMMobaUFWIEihyILJnYROphXFo; }
}

public class eNLgdbDOMSrHBbdmNNdRkOZthfUsSefoinvHtpfdeSlq7894235TClxocbTuoEPnSzxHLwinDYOfVtXiAmRcjaftW
{
    void DqCLtuigTbqhVTWDCQdWRSiDluBmmDrTEkHGfcJefzCShAeSvZhJBXFkHy() { bool ZzswtQjWdlMPXZGyqSQQWlPiqNWhRgeXzgDJljGmiKWsGfBHDDgnTqcojJFftBFwGoQrWwMHMeiMO = true; bool XcLMOeOArDIEOaceashFalROKlG = false; ZzswtQjWdlMPXZGyqSQQWlPiqNWhRgeXzgDJljGmiKWsGfBHDDgnTqcojJFftBFwGoQrWwMHMeiMO = false; ZzswtQjWdlMPXZGyqSQQWlPiqNWhRgeXzgDJljGmiKWsGfBHDDgnTqcojJFftBFwGoQrWwMHMeiMO = XcLMOeOArDIEOaceashFalROKlG; }
}

