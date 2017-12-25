﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VideoPlayControl
{
    /// <summary>
    /// 程序参数
    /// </summary>
    public class ProgParameter
    {
        #region CloundSee(云视通相关参数)
        /// <summary>
        /// 云视通初始化端口
        /// </summary>
        public static int intCloundSee_intLocStartPort = ProgConstants.c_intCloundSee_intLocStartPort;

        /// <summary>
        /// 云视通临时文件存放位置
        /// </summary>
        public static string strCloundSee_TempDicPath = ProgConstants.ro_strCloundSee_TempDicPath;
        #endregion

        #region Ezviz (萤石云相关参数)
        
        /// <summary>
        /// 萤石云 开放平台认证中心地址
        /// </summary>
        public static string strEzviz__AuthAddr = ProgConstants.c_strEzviz_AuthAddr_Default;
        
        /// <summary>
        /// 萤石云 开放平台后台地址
        /// </summary>
        public static string strEzviz__PlatForm = ProgConstants.c_strEzviz_PlatForm_Default;
        
        /// <summary>
        /// 萤石云 APPID
        /// </summary>
        public static string strEzviz__AppID = ProgConstants.c_strEzviz_AppID_Default;

        /// <summary>
        /// 萤石云 AppSecret 
        /// </summary>
        public static string strEzviz_AppSecret = ProgConstants.c_strEzviz_AppSecret_Default;

        public static string strEzviz_AccessToken = "at.do2lz6k485mc38pr3n8t74vv2gm10uqm-8kx8l74m7b-04p6ip5-so5iigvth";

        #endregion

        #region 时刻视频SDK相关参数
        /// <summary>
        /// 时刻视频_控制端口
        /// </summary>
        public static UInt16 uintSKVideo_ControlPort = 47624;

        /// <summary>
        /// 时刻视频_视频端口
        /// </summary>
        public static UInt16 uintSKVideo_VideoPort = 47724;

        /// <summary>
        /// 时刻视频_音频端口
        /// </summary>
        public static UInt16 uintSKVideo_AudioPort = 47824;
        /// <summary>
        /// 时刻视频_码流端口
        /// </summary>
        public static UInt16 uintSKVideo_AVPort = 47924;

        /// <summary>
        /// 服务器IP
        /// </summary>
        public static string strSKVideo_ServerIP = "121.41.87.203";

        /// <summary>
        /// 客户端ID
        /// </summary>
        public static string strSKVideo_ClientUGID = "xhcs1";


        #endregion
    }
}
