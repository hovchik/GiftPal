using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GiftPalServer.DbContext;

namespace GiftPalServer.Repository
{
    public class UnitOfWorks : IDisposable, IUnitOfWork
    {
        private GiftPalDbContext db = new GiftPalDbContext();

        private UserRepository _bookRepository;
        private GiftsRepository _giftsRepository;
        private FeedbackRepository _feedbackRepository;
        private ToSendRepository ToSendRepository;
        //private ReceivedGoodsRepository _receivedGoodsRepository;
        //private SentGoodsRepository _sentGoodsRepository;
        private ShippingAddressRepository _shippingAddressRepository;
        //private UserRelationsRepository _userRelationsRepository;

        public GiftsRepository Gift
        {
            get
            {
                if (_giftsRepository == null)
                    _giftsRepository = new GiftsRepository(db);
                return _giftsRepository;

            }
        }
        public ToSendRepository ToSends
        {
            get
            {
                if (ToSendRepository == null)
                    ToSendRepository = new ToSendRepository(db);
                return ToSendRepository;
            }
        }
        public FeedbackRepository Feedback
        {
            get
            {
                if (_feedbackRepository == null)
                    _feedbackRepository = new FeedbackRepository(db);
                return _feedbackRepository;
            }
        }
        //public ReceivedGoodsRepository ReceivedGoods
        //{
        //    get
        //    {
        //        if (_receivedGoodsRepository == null)
        //            _receivedGoodsRepository = new ReceivedGoodsRepository(db);
        //        return _receivedGoodsRepository;
        //    }
        //}
        //public SentGoodsRepository SentGoods
        //{
        //    get
        //    {
        //        if (_sentGoodsRepository == null)
        //            _sentGoodsRepository = new SentGoodsRepository(db);
        //        return _sentGoodsRepository;
        //    }
        //}
        public ShippingAddressRepository ShippingAddress
        {
            get
            {
                if (_shippingAddressRepository == null)
                    _shippingAddressRepository = new ShippingAddressRepository(db);
                return _shippingAddressRepository;
            }
        }
        //public UserRelationsRepository UserRelations
        //{
        //    get
        //    {
        //        if (_userRelationsRepository == null)
        //            _userRelationsRepository = new UserRelationsRepository(db);
        //        return _userRelationsRepository;
        //    }
        //}


        public UserRepository Users
        {
            get
            {
                if (_bookRepository == null)
                    _bookRepository = new UserRepository(db);
                return _bookRepository;
            }
        }

        public async Task Save()
        {
            await db.SaveChangesAsync();
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~UnitOfWorks() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
