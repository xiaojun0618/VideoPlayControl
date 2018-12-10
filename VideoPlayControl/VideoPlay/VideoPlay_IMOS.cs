﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PublicClassCurrency;
using VideoPlayControl.Enum;
using VideoPlayControl.VideoBasicClass;

namespace VideoPlayControl.VideoPlay
{
    /// <summary>
    /// 宇视视频
    /// </summary>
    class VideoPlay_IMOS : IVideoPlay
    {
        public VideoInfo CurrentVideoInfo { get; set; }
        public CameraInfo CurrentCameraInfo { get; set; }
        public VideoPlaySetting CurrentVideoPlaySet { get; set; }
        public IntPtr intptrPlayMain { get; set; }
        private Enum_VideoPlayState videoPlayState = Enum_VideoPlayState.VideoInfoNull;
        public Enum_VideoPlayState VideoPlayState
        {
            get { return videoPlayState; }
            set
            {
                if (videoPlayState != value)
                {
                    videoPlayState = value;
                    if (VideoPlayStateChangedEvent != null)
                    {
                        VideoPlayStateChangedEvent(this, null);
                    }
                }
            }
        }
        public int VideoplayWindowWidth { get; set; }
        public int VideoplayWindowHeight { get; set; }
        /// <summary>
        /// 音频通道状态
        /// </summary>
        public Enum_VideoPlaySoundState SoundState { get; set; }
        public event VideoPlayCallbackDelegate VideoPlayCallbackEvent;

        public event VideoPlayStateChangedDelegate VideoPlayStateChangedEvent;

        public bool VideoClose()
        {
            UInt32 ulRet = 0;
            ulRet = SDK_IMOSSDK.IMOS_StopRecord(ref SDKState.IMOSLoginInfo.stUserLoginIDInfo, Encoding.Default.GetBytes("0"));
            ulRet = SDK_IMOSSDK.IMOS_StopMonitor(ref SDKState.IMOSLoginInfo.stUserLoginIDInfo, Encoding.Default.GetBytes("0"), 0);
            ulRet = SDK_IMOSSDK.IMOS_StopPlay(ref SDKState.IMOSLoginInfo.stUserLoginIDInfo, Encoding.Default.GetBytes("0"));
            ulRet = SDK_IMOSSDK.IMOS_FreeChannelCode(ref SDKState.IMOSLoginInfo.stUserLoginIDInfo, Encoding.Default.GetBytes("0"));
            return true;
        }

        public bool VideoPlay()
        {
            SDK_IMOSSDK.IMOS_StartMonitor(ref SDKState.IMOSLoginInfo.stUserLoginIDInfo, new byte[] { 0X00, 0X01 }, Encoding.Default.GetBytes("0"), 1, 0);
            if (CurrentVideoPlaySet.VideoRecordEnable)
            {
                SDK_IMOSSDK.IMOS_StartRecord(ref SDKState.IMOSLoginInfo.stUserLoginIDInfo, Encoding.Default.GetBytes("0"),Encoding.Default.GetBytes(CurrentVideoPlaySet.PreVideoRecordFilePath), 0);
            }
            return true;
        }

        public bool VideoPlayCallback(VideoPlayCallbackValue value)
        {
            bool bolResult = false;
            if (VideoPlayCallbackEvent != null)
            {
                return VideoPlayCallbackEvent(this, value);
            }
            return bolResult;
        }

        public bool VideoPlayEx()
        {
            throw new NotImplementedException();
        }

        public bool VideoPTZControl(Enum_VideoPTZControl PTZControl, bool bolStart)
        {
            throw new NotImplementedException();
        }

        public void VideoSizeChange(int intLeft, int intRight, int intTop, int intBottom)
        {
            //throw new NotImplementedException();
        }


        public bool OpenSound()
        {
            return false;
        }

        public bool CloseSound()
        {
            return false;
        }
    }
}
