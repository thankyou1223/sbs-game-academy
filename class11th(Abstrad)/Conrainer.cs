using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class11th_Abstrad_
{
    internal class Container<T>
    {

        private T[ ] container<T>
        {
            private T[] container;
        } 

        public Container()



        

        #region 형식 매개 변수
        // 형식을 지정하지 않아도 호출 시에 형식만 지정하면
        // 어떤 형식으로 다 설정될 수 있는 매개 변수입니다.


        public void Add(T data)
        {
            this.data = data;
        }

        public T this[int index]
        {
            get { return data[indexer]; }
            set { Container[index] = value;  }
        }
        #endregion
    }
}
