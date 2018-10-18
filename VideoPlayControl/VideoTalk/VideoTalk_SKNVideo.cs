﻿using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VideoPlayControl.SDKInterface;
using VideoPlayControl.VideoBasicClass;

namespace VideoPlayControl.VideoTalk
{
    public class VideoTalk_SKNVideo:IVideoTalk
    {
        public VideoInfo CurrentVideoInfo
        { get; set; }
        public VideoTalkChannelInfo CurrentTalkChannel { get; set; }
        private Enum_TalkStatus currentTalkStatus;
        public Enum_TalkStatus CurrentTalkStatus
        {
            get
            {
                return currentTalkStatus;
            }
            set
            {
                if (currentTalkStatus != value)
                {
                    currentTalkStatus = value;
                    TalkStausChanged(null);
                }
            }
        }

        public event TalkStausChangedDelegate TalkStausChangedEvent;

        public bool TalkStausChanged(object TalkStausChangedValue)
        {
            bool bolResult = false;
            if (TalkStausChangedEvent != null)
            {
                TalkStausChangedEvent(this, TalkStausChangedValue);
            }
            return bolResult;
        }
        public event StartTalkingDelegate StartTalkingEvent;

        public bool StartTalking(object StartTalkingValue)
        {
            bool bolResult = false;
            if (StartTalkingEvent != null)
            {
                StartTalkingEvent(this, StartTalkingValue);
            }
            return bolResult;
        }

        public bool SetVideoTalkInfo(VideoInfo videoInfo, VideoTalkChannelInfo talkChannel)
        {
            bool bolResult = false;
            if (CurrentTalkStatus != Enum_TalkStatus.Null)
            {
                StopTalk();
            }
            CurrentVideoInfo = videoInfo;
            CurrentTalkChannel = talkChannel;
            return bolResult;
        }

        public bool StartTlak(Enum_TalkModel talkModel)
        {
            bool bolResult = false;
            if (CurrentTalkStatus != Enum_TalkStatus.Null)  //处于对讲中 先关闭
            {
                StopTalk();
            }
            StartTalking(null);
            SDK_SKNVideo.SDK_NSK_CLIENT_start_talk(CurrentVideoInfo.DVSAddress, Convert.ToByte(CurrentTalkChannel.VideoTalkChannel), GetSKTalkModel(talkModel),null, null);
             CurrentTalkStatus = (Enum_TalkStatus)(int)talkModel;
            return bolResult;
        }


        public bool StopTalk()
        {
            bool bolResult = false;
            SDK_SKNVideo.SDK_NSK_CLIENT_close_talk(CurrentVideoInfo.DVSAddress);
            if (CurrentVideoInfo != null && CurrentTalkStatus != Enum_TalkStatus.Null)
            {
                CurrentTalkStatus = Enum_TalkStatus.Null;
            }
            return bolResult;
        }

        public static int GetSKTalkModel(Enum_TalkModel talk)
        {
            //对讲模式,1，全双工，2，喊话，3，监听
            int intResult = 1;
            switch (talk)
            {
                case Enum_TalkModel.Talkback:
                    intResult = 1;
                    break;
                case Enum_TalkModel.Sperak:
                    intResult = 2;
                    break;
                case Enum_TalkModel.Interception:
                    intResult = 3;
                    break;

            }
            return intResult;
        }

    }
}
