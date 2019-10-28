using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;

namespace SharpAVKB
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("\n\rAuthor: Uknow");
                Console.WriteLine("Github: https://github.com/uknowsec/SharpAVKB");
                Console.WriteLine("Usage: SharpAVKB.exe -AV");
                Console.WriteLine("       SharpAVKB.exe -KB");

            }
            if (args.Length == 1 && args[0] == "-AV")
            {
                Console.WriteLine("\n\r========== SharpAVKB --> GetWindowsAnti-VirusSoftware ==========\n\r");
                av();
            }
            if (args.Length == 1 && args[0] == "-KB")
            {
                Console.WriteLine("\n\r========== SharpAVKB --> GetWindowsKernelExploitsKB ==========\n\r");
                kb();
            }
        }


        public static void av()
        {

            Dictionary<string, string> av_list = new Dictionary<string, string>();
            av_list.Add("360tray.exe", "360安全卫士-实时保护");
            av_list.Add("360safe.exe", "360安全卫士-主程序");
            av_list.Add("ZhuDongFangYu.exe", "360安全卫士-主动防御");
            av_list.Add("360sd.exe", "360杀毒");
            av_list.Add("a2guard.exe", "a-squared杀毒");
            av_list.Add("ad-watch.exe", "Lavasoft杀毒");
            av_list.Add("cleaner8.exe", "The Cleaner杀毒");
            av_list.Add("vba32lder.exe", "vb32杀毒");
            av_list.Add("MongoosaGUI.exe", "Mongoosa杀毒");
            av_list.Add("CorantiControlCenter32.exe", "Coranti2012杀毒");
            av_list.Add("F-PROT.exe", "F-Prot AntiVirus");
            av_list.Add("CMCTrayIcon.exe", "CMC杀毒");
            av_list.Add("K7TSecurity.exe", "K7杀毒");
            av_list.Add("UnThreat.exe", "UnThreat杀毒");
            av_list.Add("CKSoftShiedAntivirus4.exe", "Shield Antivirus杀毒");
            av_list.Add("AVWatchService.exe", "VIRUSfighter杀毒");
            av_list.Add("ArcaTasksService.exe", "ArcaVir杀毒");
            av_list.Add("iptray.exe", "Immunet杀毒");
            av_list.Add("PSafeSysTray.exe", "PSafe杀毒");
            av_list.Add("nspupsvc.exe", "nProtect杀毒");
            av_list.Add("SpywareTerminatorShield.exe", "SpywareTerminator杀毒");
            av_list.Add("BKavService.exe", "Bkav杀毒");
            av_list.Add("MsMpEng.exe", "Microsoft Security Essentials");
            av_list.Add("SBAMSvc.exe", "VIPRE");
            av_list.Add("ccSvcHst.exe", "Norton杀毒");
            av_list.Add("f-secure.exe", "冰岛");
            av_list.Add("avp.exe", "Kaspersky");
            av_list.Add("KvMonXP.exe", "江民杀毒");
            av_list.Add("RavMonD.exe", "瑞星杀毒");
            av_list.Add("Mcshield.exe", "Mcafee");
            av_list.Add("Tbmon.exe", "Mcafee");
            av_list.Add("Frameworkservice.exe", "Mcafee");
            av_list.Add("egui.exe", "ESET NOD32");
            av_list.Add("ekrn.exe", "ESET NOD32");
            av_list.Add("eguiProxy.exe", "ESET NOD32");
            av_list.Add("kxetray.exe", "金山毒霸");
            av_list.Add("knsdtray.exe", "可牛杀毒");
            av_list.Add("TMBMSRV.exe", "趋势杀毒");
            av_list.Add("avcenter.exe", "Avira(小红伞)");
            av_list.Add("avguard.exe", "Avira(小红伞)");
            av_list.Add("avgnt.exe", "Avira(小红伞)");
            av_list.Add("sched.exe", "Avira(小红伞)");
            av_list.Add("ashDisp.exe", "Avast网络安全");
            av_list.Add("rtvscan.exe", "诺顿杀毒");
            av_list.Add("ccapp.exe", "Symantec Norton");
            av_list.Add("NPFMntor.exe", "Norton杀毒软件相关进程");
            av_list.Add("ccSetMgr.exe", "赛门铁克");
            av_list.Add("ccRegVfy.exe", "Norton杀毒软件自身完整性检查程序");
            av_list.Add("vptray.exe", "Norton病毒防火墙-盾牌图标程序");
            av_list.Add("ksafe.exe", "金山卫士");
            av_list.Add("QQPCRTP.exe", "QQ电脑管家");
            av_list.Add("Miner.exe", "流量矿石");
            av_list.Add("AYAgent.exe", "韩国胶囊");
            av_list.Add("patray.exe", "安博士");
            av_list.Add("V3Svc.exe", "安博士V3");
            av_list.Add("avgwdsvc.exe", "AVG杀毒");
            av_list.Add("QUHLPSVC.exe", "QUICK HEAL杀毒");
            av_list.Add("mssecess.exe", "微软杀毒");
            av_list.Add("SavProgress.exe", "Sophos杀毒");
            av_list.Add("fsavgui.exe", "F-Secure杀毒");
            av_list.Add("vsserv.exe", "比特梵德");
            av_list.Add("remupd.exe", "熊猫卫士");
            av_list.Add("FortiTray.exe", "飞塔");
            av_list.Add("safedog.exe", "安全狗");
            av_list.Add("parmor.exe", "木马克星");
            av_list.Add("Iparmor.exe.exe", "木马克星");
            av_list.Add("beikesan.exe", "贝壳云安全");
            av_list.Add("KSWebShield.exe", "金山网盾");
            av_list.Add("TrojanHunter.exe", "木马猎手");
            av_list.Add("GG.exe", "巨盾网游安全盾");
            av_list.Add("adam.exe", "绿鹰安全精灵");
            av_list.Add("AST.exe", "超级巡警");
            av_list.Add("ananwidget.exe", "墨者安全专家");
            av_list.Add("AVK.exe", "GData");
            av_list.Add("avg.exe", "AVG Anti-Virus");
            av_list.Add("spidernt.exe", "Dr.web");
            av_list.Add("avgaurd.exe", "Avira Antivir");
            av_list.Add("vsmon.exe", "ZoneAlarm");
            av_list.Add("cpf.exe", "Comodo");
            av_list.Add("outpost.exe", "Outpost Firewall");
            av_list.Add("rfwmain.exe", "瑞星防火墙");
            av_list.Add("kpfwtray.exe", "金山网镖");
            av_list.Add("FYFireWall.exe", "风云防火墙");
            av_list.Add("MPMon.exe", "微点主动防御");
            av_list.Add("pfw.exe", "天网防火墙");
            av_list.Add("1433.exe", "在扫1433");
            av_list.Add("DUB.exe", "在爆破");
            av_list.Add("ServUDaemon.exe", "发现S-U");
            av_list.Add("BaiduSdSvc.exe", "百度杀毒-服务进程");
            av_list.Add("BaiduSdTray.exe", "百度杀毒-托盘进程");
            av_list.Add("BaiduSd.exe", "百度杀毒-主程序");
            av_list.Add("SafeDogGuardCenter.exe", "安全狗");
            av_list.Add("safedogupdatecenter.exe", "安全狗");
            av_list.Add("safedogguardcenter.exe", "安全狗");
            av_list.Add("SafeDogSiteIIS.exe", "安全狗");
            av_list.Add("SafeDogTray.exe", "安全狗");
            av_list.Add("SafeDogServerUI.exe", "安全狗");
            av_list.Add("D_Safe_Manage.exe", "D盾");
            av_list.Add("d_manage.exe", "D盾");
            av_list.Add("yunsuo_agent_service.exe", "云锁");
            av_list.Add("yunsuo_agent_daemon.exe", "云锁");
            av_list.Add("HwsPanel.exe", "护卫神");
            av_list.Add("hws_ui.exe", "护卫神");
            av_list.Add("hws.exe", "护卫神");
            av_list.Add("hwsd.exe", "护卫神");
            av_list.Add("hipstray.exe", "火绒");
            av_list.Add("wsctrl.exe", "火绒");
            av_list.Add("usysdiag.exe", "火绒");
            av_list.Add("WEBSCANX.EXE", "网络病毒克星");
            av_list.Add("SPHINX.EXE", "SPHINX防火墙");
            av_list.Add("bddownloader.exe", "百度卫士");
            av_list.Add("baiduansvx.exe", "百度卫士-主进程");
            av_list.Add("AvastUI.exe", "Avast!5主程序");
            Cmd c = new Cmd();
            Console.WriteLine("正在获取杀软信息请稍等。。。\n\r");
            string resultStr = c.RunCmd("tasklist /svc");
            Console.WriteLine("存在杀软信息如下：");
            foreach (KeyValuePair<string, string> kvp in av_list)
            {
                if (resultStr.IndexOf(kvp.Key) > -1)
                {
                    Console.WriteLine(kvp.Key + ":" + kvp.Value);
                }
            }
        }

        public static void kb()
        {
            Console.WriteLine("正在获取补丁信息请稍等。。。\n\r");
            Dictionary<string, string> kb_num = new Dictionary<string, string>();
            kb_num.Add("KB4013081", "MS17-017");
            kb_num.Add("KB4013389", "MS17-010");
            kb_num.Add("KB3199135", "MS16-135");
            kb_num.Add("KB3186973", "MS16-111");
            kb_num.Add("KB3178466", "MS16-098");
            kb_num.Add("KB3164038", "MS16-075");
            kb_num.Add("KB3143145", "MS16-034");
            kb_num.Add("KB3143141", "MS16-032");
            kb_num.Add("KB3136041", "MS16-016");
            kb_num.Add("K3134228", "MS16-014");
            kb_num.Add("KB3089656", "MS15-097");
            kb_num.Add("KB3067505", "MS15-076");
            kb_num.Add("KB3077657", "MS15-077");
            kb_num.Add("KB3057839", "MS15-061");
            kb_num.Add("KB3057191", "MS15-051");
            kb_num.Add("KB3031432", "MS15-015");
            kb_num.Add("KB3036220", "MS15-010");
            kb_num.Add("KB3023266", "MS15-001");
            kb_num.Add("KB2989935", "MS14-070");
            kb_num.Add("KB3011780", "MS14-068");
            kb_num.Add("KB3000061", "MS14-058");
            kb_num.Add("KB2992611", "MS14-066");
            kb_num.Add("KB2975684", "MS14-040");
            kb_num.Add("KB2914368", "MS14-002");
            kb_num.Add("KB2850851", "MS13-053");
            kb_num.Add("KB2840221", "MS13-046");
            kb_num.Add("KB2778930", "MS13-005");
            kb_num.Add("KB2972621", "MS12-042");
            kb_num.Add("KB2671387", "MS12-020");
            kb_num.Add("KB2592799", "MS11-080");
            kb_num.Add("KB2566454", "MS11-062");
            kb_num.Add("KB2503665", "MS11-046");
            kb_num.Add("KB2393802", "MS11-011");
            kb_num.Add("KB2305420", "MS10-092");
            kb_num.Add("KB2267960", "MS10-065");
            kb_num.Add("KB982799", "MS10-059");
            kb_num.Add("KB2160329", "MS10-048");
            kb_num.Add("KB977165", "MS10-015");
            kb_num.Add("KB971468", "MS10-012");
            kb_num.Add("KB975517", "MS09-050");
            kb_num.Add("KB970483", "MS09-020");
            kb_num.Add("KB959454", "MS09-012");
            kb_num.Add("KB957097", "MS08-068");
            kb_num.Add("KB958644", "MS08-067");
            kb_num.Add("KB956803", "MS08-066");
            kb_num.Add("KB941693", "MS08-025");
            kb_num.Add("KB921883", "MS06-040");
            kb_num.Add("KB899588", "MS05-039");
            kb_num.Add("KB823980", "MS03-026");
            var kb_exp = new List<string> { "KB4013081", "KB4013389", "KB3199135", "KB3186973", "KB3178466", "KB3164038", "KB3143145", "KB3143141", "KB3136041", "K3134228", "KB3089656", "KB3067505", "KB3077657", "KB3057839", "KB3057191", "KB3031432", "KB3036220", "KB3023266", "KB2989935", "KB3011780", "KB3000061", "KB2992611", "KB2975684", "KB2914368", "KB2850851", "KB2840221", "KB2778930", "KB2972621", "KB2671387", "KB2592799", "KB2566454", "KB2503665", "KB2393802", "KB2305420", "KB2267960", "KB982799", "KB2160329", "KB977165", "KB971468", "KB975517", "KB970483", "KB959454", "KB957097", "KB958644", "KB956803", "KB941693", "KB921883", "KB899588", "KB823980" };
            var sys_kb = new List<string> { };
            Cmd c = new Cmd();
            string all = c.RunCmd("systeminfo | findstr \"KB\"");
            Regex re = new Regex(@"]: (.*)", RegexOptions.Multiline);
            MatchCollection mc = re.Matches(all);
            foreach (Match ma in mc)
            {
                sys_kb.Add(ma.ToString().Replace("]: ", ""));

            }
            Console.WriteLine("存在补丁信息如下：");
            foreach (var item in kb_exp)
            {
                if (!sys_kb.Contains(item))
                {
                    Console.WriteLine("KB号:" + item + "    MS号:" + kb_num[item]);
                }
            }
        }
    }

    /// <summary>
    /// Cmd 的摘要说明。
    /// </summary>
    public class Cmd
    {
        private Process proc = null;
        /// <summary>
        /// 构造方法
        /// </summary>
        public Cmd()
        {
            proc = new Process();
        }
        /// <summary>
        /// 执行CMD语句
        /// </summary>
        /// <param name="cmd">要执行的CMD命令</param>
        public string RunCmd(string cmd)
        {
            proc.StartInfo.CreateNoWindow = true;
            proc.StartInfo.FileName = "cmd.exe";
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardError = true;
            proc.StartInfo.RedirectStandardInput = true;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.Start();
            proc.StandardInput.WriteLine(cmd);
            proc.StandardInput.WriteLine("exit");
            string outStr = proc.StandardOutput.ReadToEnd();
            proc.Close();
            return outStr;
        }
    }
}
