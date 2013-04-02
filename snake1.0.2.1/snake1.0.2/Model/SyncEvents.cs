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
            _foodEatingEvent = new AutoResetEvent(false);
            _exitThreadEvent = new AutoResetEvent(false);
            _mapSizeChanged = new AutoResetEvent(false);
            _eventArray = new WaitHandle[7];
            _eventArray[0] = _produceCollectionEvent;
            _eventArray[1] = _comsumeCollectionEvent;
            _eventArray[2] = _mouvementChangeEvent;
            _eventArray[3] = _foodEatingEvent;
            _eventArray[4] = _newFoodLocationEvent;
            _eventArray[5] = _mapSizeChanged;
            _eventArray[6] = _exitThreadEvent;
        }

        public EventWaitHandle MapSizeChanged
        {
            get { return _mapSizeChanged; }
        }
        public EventWaitHandle FoodEatingEvent
        {
            get { return _foodEatingEvent; }
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
        private EventWaitHandle _foodEatingEvent;
        private EventWaitHandle _newFoodLocationEvent;
        private EventWaitHandle _mapSizeChanged;
        private EventWaitHandle _exitThreadEvent;
        private WaitHandle[] _eventArray;
    }
}
