using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.Events;
using UnityEngine.Playables;

namespace Phantom.XRMOD.UIFramework.Runtime
{
    public class TimelinePlayController : MonoBehaviour
    {
        public PlayableDirector PlayableDirector;
        public TimelineSegmentationConfig[] TimelineSegmentationConfigs;

        private IEnumerator stopAtCoroutine;


        private void Awake()
        {
            if (PlayableDirector == null)
                PlayableDirector = GetComponentInChildren<PlayableDirector>();

            Assert.IsNotNull(PlayableDirector, "Timeline play controller has not been attached.");
        }

        private void OnDisable()
        {
            if (stopAtCoroutine != null)
            {
                StopCoroutine(stopAtCoroutine);
                stopAtCoroutine = null;
            }
        }

        public void Play()
        {
            if (!PlayableDirector.gameObject.activeInHierarchy) return;
            if (PlayableDirector.state == PlayState.Playing) return;
            
            PlayableDirector.Play();
        }

        public void Play(int _segmentationId, float _delayToPlay = 0)
        {
            var tmp_SegmentationConfig = TimelineSegmentationConfigs[_segmentationId];
            PlayTimeline(tmp_SegmentationConfig, _delayToPlay);
        }


        public void Play(string _segmentationName, float _delayToPlay = 0)
        {
            var tmp_SegmentationConfig = TimelineSegmentationConfigs.FirstOrDefault(_segmentation =>
                _segmentation.SegmentationName == _segmentationName);

            if (tmp_SegmentationConfig == null)
            {
                Debug.LogError($"No segmentation named {_segmentationName}");
                return;
            }

            PlayTimeline(tmp_SegmentationConfig, _delayToPlay);
        }


        public void Play(TimelineSegmentationConfig _segmentationConfig, float _delayToPlay = 0)
        {
            PlayTimeline(_segmentationConfig, _delayToPlay);
        }


        public void Stop()
        {
            PlayableDirector.Stop();
        }

        public void Pause()
        {
            PlayableDirector.Pause();
        }


        private async void PlayTimeline(TimelineSegmentationConfig _segmentationConfig, float _delayToPlay = 0)
        {
            try
            {
                if (!PlayableDirector.gameObject.activeInHierarchy) return;
                if (PlayableDirector.state == PlayState.Playing) return;

                await Task.Delay(Mathf.CeilToInt(_delayToPlay * 1000));


                PlayableDirector.time = _segmentationConfig.SegmentationStartTime;
                PlayableDirector.Play();

                stopAtCoroutine = StopAt(_segmentationConfig);
                StartCoroutine(stopAtCoroutine);
            }
            catch (Exception e)
            {
                Debug.LogError(e);
                throw; // TODO handle exception
            }
        }


        private IEnumerator StopAt(TimelineSegmentationConfig _segmentationConfig)
        {
            Assert.IsNotNull(_segmentationConfig);

            _segmentationConfig?.OnStart.Invoke();

            var tmp_StopTime = _segmentationConfig.SegmentationStartTime +
                               _segmentationConfig.SegmentationDuration;
            while (PlayableDirector.time < tmp_StopTime && PlayableDirector.state == PlayState.Playing)
            {
                yield return null;
                _segmentationConfig?.OnPlaying.Invoke();
            }

            PlayableDirector.Stop();
            _segmentationConfig?.OnCompleted.Invoke();

            if (stopAtCoroutine == null) yield break;
            StopCoroutine(stopAtCoroutine);
            stopAtCoroutine = null;
        }
    }

    [System.Serializable]
    public class TimelineSegmentationConfig
    {
        public string SegmentationName;
        public double SegmentationStartTime;
        public double SegmentationDuration;
        [Space] public UnityEvent OnStart;
        public UnityEvent OnPlaying;
        public UnityEvent OnCompleted;
    }
}