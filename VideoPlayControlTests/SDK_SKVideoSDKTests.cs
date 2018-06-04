﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using VideoPlayControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static VideoPlayControl.SDK_SKVideoSDK;
using System.Runtime.InteropServices;
using System.Threading;
using VideoPlayControl.VideoBasicClass;
using CommonMethod;
using System.IO;

namespace VideoPlayControl.Tests
{
    [TestClass()]
    public class SDK_SKVideoSDKTests
    {
        private CallBack p_msg_demo_callback;
        List<RemoteVideoRecordInfo> lRemoteVideoRecord;
        public SDK_SKVideoSDKTests()
        {
            SDK_SKVideoSDK.p_sdkc_init_client("SK-20140902-000000", "127.0.0.1", 47624, 47724, 47824, @"d:\");
        }
        [TestMethod()]
        public void p_sdkc_get_record_time_mapTest()
        {
            //1.注册回调
            //2.创建线程
            //3.触发回调事件

            p_msg_demo_callback = new CallBack(callback);
            p_sdkc_reg_msg_callback(p_msg_demo_callback);
            while (SDK_SKVideoSDK.p_sdkc_get_online() == 0)
            {
                Common.Delay_Second(1);
            }
            long start_time = ConvertClass.DateTimeToUnixTimestamp(DateTime.Now.AddDays(-1));
            long stop_time = ConvertClass.DateTimeToUnixTimestamp(DateTime.Now);
            SDK_SKVideoSDK.p_sdkc_get_record_time_map("61-57354AA60831-3136", (byte)8, (int)start_time, (int)stop_time);
            Common.Delay_Second(5);
            Assert.Fail();
        }

        public void callback(UInt32 msg_id, UInt32 arg1, UInt32 arg2, IntPtr data1, UInt32 data1_len, IntPtr data2, UInt32 data2_len)
        {
            st_event st = new st_event();
            switch (msg_id)
            {
                case 12:
                    {
                        st = (st_event)Marshal.PtrToStructure(data1, typeof(st_event));
                        string str = Encoding.Default.GetString(st.event_data);
                        string guid = System.Text.Encoding.Default.GetString(st.guid);
                        int i = guid.IndexOf("\0");
                        if (i > 0)
                        {
                            guid = guid.Substring(0, i);
                        }
                        int Temp_intChannelIndex = str.IndexOf("c:");
                        if (str.IndexOf("{") < 0 && Temp_intChannelIndex > 0)
                        {
                            //存在 { }代表事件内容
                            //认为是录像信息进行解析
                            lRemoteVideoRecord = SDK_SKVideoSDK.SKRemoteVideoRecordDataPrasing(guid, str);
                        }
                    }
                    break;
                default:
                    break;
            }

        }

        [TestMethod()]
        public void DataPrasingTest()
        {
            string strData = "[a:192.168.2.166][g:SuperAdmin_PB][c:08][s(1526886082) e(1526886150)][s(1526886179) e(1526887395)][s(1526887503) e(1526889215)][s(1526889314) e(1526892684)][s(1526892685) e(1526895368)][s(1526895368) e(1526898051)][s(1526898051) e(1526900729)]";
            List<RemoteVideoRecordInfo> l = SDK_SKVideoSDK.SKRemoteVideoRecordDataPrasing("61-57354AA60831-3136", strData);
            Assert.AreEqual(l.Count, 1);
        }

        [TestMethod()]
        public void DownLoadRemoteRecordDataTest()
        {
            string Temp_strDownPath = @"C:\SHIKE_Video\0138\DownloadTest";

            p_msg_demo_callback = new CallBack(callback);
            p_sdkc_reg_msg_callback(p_msg_demo_callback);
            while (SDK_SKVideoSDK.p_sdkc_get_online() == 0)
            {
                Common.Delay_Second(1);
            }
            long start_time = ConvertClass.DateTimeToUnixTimestamp(DateTime.Now.AddHours(-1));
            long stop_time = ConvertClass.DateTimeToUnixTimestamp(DateTime.Now);
            SDK_SKVideoSDK.p_sdkc_get_record_time_map("61-57354AA60831-3136", (byte)8, (int)start_time, (int)stop_time);
            Common.Delay_Second(5);
            if (lRemoteVideoRecord != null && lRemoteVideoRecord.Count > 0)
            {
                foreach (RemoteVideoRecordInfo v in lRemoteVideoRecord)
                {
                    SDK_SKVideoSDK.DownLoadRemoteRecord(v, Temp_strDownPath + "/" + v.RemoteVidoRecordName);
                }
            }
            Assert.Fail();
        }

        [TestMethod()]
        public void DownLoadRemoteRecordTest()
        {
            string Temp_strDownPath = @"C:\SHIKE_Video\0138\DownloadTest";
            string strData = "[a:192.168.2.166][g:xhcs1][c:08][s(1526886082) e(1526886150)][s(1526886179) e(1526887395)][s(1526887503) e(1526889215)][s(1526889314) e(1526892684)][s(1526892685) e(1526895368)][s(1526895368) e(1526898051)][s(1526898051) e(1526900729)][s(1526900730) e(1526903405)][s(1526903405) e(1526906087)][s(1526906087) e(1526908768)][s(1526908768) e(1526911452)][s(1526911452) e(1526912030)][s(1526945754) e(1526948443)][s(1526948444) e(1526951130)][s(1526951130) e(1526953814)][s(1526953814) e(1526956492)][s(1526956492) e(1526959175)][s(1526959175) e(1526961854)][s(1526961854) e(1526964531)][s(1526964531) e(1526967215)][s(1526967215) e(4294966)]";
            List<RemoteVideoRecordInfo> l = SDK_SKVideoSDK.SKRemoteVideoRecordDataPrasing("61-57354AA60831-3136", strData);
            string strFileName = "";
            RemoteVideoRecordInfo v = l[0];
            strFileName = Temp_strDownPath + "/" + v.RemoteVidoRecordName;
            while (SDK_SKVideoSDK.p_sdkc_get_online() == 0)
            {
                Common.Delay_Second(1);
            }
            SDK_SKVideoSDK.DownLoadRemoteRecord(v, strFileName);
            Assert.IsTrue(File.Exists(strFileName));
        }

        [TestMethod()]
        public void GetRemoteVideoRecordFileNameTest()
        {
            string strResult = "VHS_ch09_61-57354AA60831-3136_1526886082.h264";
            RemoteVideoRecordInfo V = new RemoteVideoRecordInfo
            {
                VideoGUID = "61-57354AA60831-3136",
                StartTime = DateTime.Parse("2018-05-21 15:01:22"),
                Channel = 8,
            };
            string Temp_str = SDK_SKVideoSDK.GetRemoteVideoRecordFileName(V);
            Assert.AreEqual(Temp_str, strResult);
        }

        [TestMethod()]
        public void p_sdkc_request_download_videoTest()
        {
            DateTime timStart = DateTime.Now.AddSeconds(-3000);
            DateTime timEnd = DateTime.Now.AddSeconds(-2700);
            long start_time = ConvertClass.DateTimeToUnixTimestamp(timStart);
            long stop_time = ConvertClass.DateTimeToUnixTimestamp(timEnd);
            int intCount = 0;
            while (SDK_SKVideoSDK.p_sdkc_get_online() == 0 && intCount < 10)
            {
                Common.Delay_Second(1);
                intCount++;
            }
            string Temp_strDownPath = @"C:\SHIKE_Video\0138\DownloadTest\" + timStart.ToString("yyyy_MM_dd_HH_mm_ss") + ".H264";
            //string Temp_strDownPath = @"C:\SHIKE_Video\0138\DownloadTest";
            int intResult = SDK_SKVideoSDK.p_sdkc_request_download_video("61-57354AA60831-3136", 0, (int)start_time, (int)stop_time, Temp_strDownPath);
            intCount = 0;
            Common.Delay_Second(30);
            Assert.AreEqual(intResult, 1);
        }

        [TestMethod()]
        public void GetPictureForVideoRecordTest()
        {
            string strSavePath = @"G:\Test";
            //bool bolResult = GetPictureForVideoRecord(@"C:\SHIKE_Video\9999\20180531021956\61-57354AA60831-3136_20180531022002_01_bfr10.H264", strSavePath, 10);
            //bool bolResult = GetPictureForVideoRecord(@"C:\SHIKE_Video\9999\20180531194905\61-57354AA60831-3136_20180531194919_01_bfr10.H264", strSavePath, 5, 1000);
            string s = @"C:\SHIKE_Video\9999\20180531223110\61-57354AA60831-3136_20180531223118_01_bfr10.H264";
            bool bolResult = GetPictureForVideoRecord(s, strSavePath, 7, 5000);

            //Thread.Sleep(3000);
            Assert.IsTrue(bolResult);
        }

        [TestMethod()]
        public void testcTest()
        {

            string strSavePath = @"G:\Test";
            string strFilePath = @"C:\SHIKE_Video\9999\20180531194905\61-57354AA60831-3136_20180531194919_01_bfr10.H264";
            //int intCountSecond = GetMediaTimeLenSecond(strFilePath);
            bool bolResult = RePicname(strSavePath, DateTime.Now, 1, 5);

            Assert.IsTrue(bolResult);
        }

        [TestMethod()]
        public void GetChannelByBFRNameTest()
        {
            string s = "61-57354AA60831-3136_20180531194919_01_bfr10.H264";
            int intChannel = GetChannelByBFRName(s);
            Assert.AreEqual(1, intChannel);
        }

        [TestMethod()]
        public void GetEndTimeByBFRNameTest()
        {
            string s = "61-57354AA60831-3136_20180531194919_01_bfr10.H264";
            DateTime tim = GetTimeByBFRName(s);
            Assert.AreEqual(tim, DateTime.Now);
        }

        [TestMethod()]
        public void testttTest()
        {
            testtt();
            Assert.Fail();
        }

        [TestMethod()]
        public void CreatePCMFileTest()
        {
            string strG711File = @"C:\SHIKE_Video\SKAlarmAudio\9999\20180602142359\61-57354AA60831-3136_20180602142406_09_bfr10.G711";
            string strPcmFile= @"C:\SHIKE_Video\SKAlarmAudio\9999\20180602142359\61-57354AA60831-3136_20180602142406_09_bfr10.pcm";
            string strWavFile = @"C:\SHIKE_Video\SKAlarmAudio\9999\20180602142359\61-57354AA60831-3136_20180602142406_09_bfr10.wav";
            //SDK_SKVideoSDK.CreatePCMFile(strG711File, strPcmFile);
            SDK_SKVideoSDK.CreateWAVFile(strG711File, strWavFile);
            Assert.Fail();
        }
    }
}