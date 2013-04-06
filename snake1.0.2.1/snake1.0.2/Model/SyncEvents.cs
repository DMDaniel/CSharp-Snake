using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace snake1._0._2.Model
{
    class SyncEvents
    {
        public SyncEvents()
        {

            _produceCollectionEvent = new AutoResetEvent(false);
            _comsumeCollectionEvent = new AutoResetEvent(false);
            _mouvementChangeEvent = new AutoResetEvent(false);
            _newFoodLocationEvent = new AutoResetEvent(false);
            _selfBodyEatingEvent = new AutoResetEvent(false);
            _appleHaveBeenEatedEvent = new AutoResetEvent(false);
            _exitThreadEvent = new AutoResetEvent(false);
            _mapSizeChanged = new AutoResetEvent(false);
            _eventArray = new WaitHandle[8];
            _eventArray[0] = _produceCollectionEvent;
            _eventArray[1] = _comsumeCollectionEvent;
            _eventArray[2] = _mouvementChangeEvent;
            _eventArray[3] = _selfBodyEatingEvent;
            _eventArray[4] = _appleHaveBeenEatedEvent;
            _eventArray[5] = _newFoodLocationEvent;
            _eventArray[6] = _mapSizeChanged;
            _eventArray[7] = _exitThreadEvent;
        }

        public EventWaitHandle MapSizeChanged
        {
            get { return _mapSizeChanged; }
        }
        public EventWaitHandle SelfBodyEatingEvent
        {
            get { return _selfBodyEatingEvent; }
        }
        public EventWaitHandle AppleHaveBeenEatedEvent
        {
            get { return _appleHaveBeenEatedEvent; }
        }
        public EventWaitHandle NewFoodLocationEvent
        {
            get { return _newFoodLocationEvent; }
        }
        public EventWaitHandle ExitThreadEvent
        {
            get { return _exitThreadEvent; }
        }
        public EventWaitHandle ProduceCollectionEvent
        {
            get { return _produceCollectionEvent; }
        }
        public EventWaitHandle ComsumeCollectionEvent
        {
            get { return _comsumeCollectionEvent; }
        }
        public EventWaitHandle MouvementChangeEvent
        {
            get { return _mouvementChangeEvent; }
        }
        public WaitHandle[] EventArray
        {
            get { return _eventArray; }
        }

        private EventWaitHandle _produceCollectionEvent;
        private EventWaitHandle _comsumeCollectionEvent;
        private EventWaitHandle _mouvementChangeEvent;
        private EventWaitHandle _selfBodyEatingEvent;
        private EventWaitHandle _appleHaveBeenEatedEvent;
        private EventWaitHandle _newFoodLocationEvent;
        private EventWaitHandle _mapSizeChanged;
        private EventWaitHandle _exitThreadEvent;
        private WaitHandle[] _eventArray;
    }
}
