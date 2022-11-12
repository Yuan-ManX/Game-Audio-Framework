using System;
using UnityEngine;

namespace GameAudioSystem
{
    /// <summary>
    /// 音频数据
    /// </summary>
    [Serializable]
    public class AudioData
    {
        public string name;

        public AudioClip clip;
    }
}