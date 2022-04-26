using System;

namespace ktr1_ctdlvagt
{
    class TimKiem
    {
        

        static void nhap(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("a[" + i + "]=");
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        static void XuatTimKiem(int[] a, int n)
        {
            Console.Write("Hien thi mang:\n");
            for (int i = 0; i < n; i++)
                Console.Write(a[i] + "\n");
        }

        public static int TimKiemTuyenTinh(int[] a, int x)
        {
            
            int n = a.Length;
            for (int i = 0; i < n; i++)
            {
                if (a[i] == x)
                    return i;
            }
            return -1;
        }

        public static int TimKiemNhiPhan(int[] a, int l, int r, int x)
        {
            
            if (r >= l)
            {
                int mid = l + (r - l) / 2;

                if (a[mid] == x)
                    return mid;

                if (a[mid] > x)
                    return TimKiemNhiPhan(a, l, mid - 1, x);

                return TimKiemNhiPhan(a, mid + 1, r, x);
            }
            return -1;
        }

        public static int TimKiemTamPhan(int l, int r, int key, int[] ar)
        {
            
            if (r >= l)
            {
                int mid1 = l + (r - l) / 3;
                int mid2 = r - (r - l) / 3;

                if (ar[mid1] == key)
                {
                    return mid1;
                }
                if (ar[mid2] == key)
                {
                    return mid2;
                }

                if (key < ar[mid1])
                {
                    return TimKiemTamPhan(l, mid1 - 1, key, ar);
                }
                else if (key > ar[mid2])
                {
                    return TimKiemTamPhan(mid2 + 1, r, key, ar);
                }
                else
                {
                    return TimKiemTamPhan(mid1 + 1, mid2 - 1, key, ar);
                }
            }

            return -1;
        }

        public static int jumpSearch(int[] a, int x)
        {
            
            int n = a.Length;
            int step = (int)Math.Floor(Math.Sqrt(n));

            int prev = 0;
            while (a[Math.Min(step, n) - 1] < x)
            {
                prev = step;
                step += (int)Math.Floor(Math.Sqrt(n));
                if (prev >= n)
                    return -1;
            }

            while (a[prev] < x)
            {
                prev++;

                if (prev == Math.Min(step, n))
                    return -1;
            }

            if (a[prev] == x)
                return prev;

            return -1;
        }

        static int TimKiemMu(int[] a, int n, int x)
        {
            
            if (a[0] == x)
                return 0;

            int i = 1;
            while (i < n && a[i] <= x)
                i = i * 2;

            return TimKiemNhiPhan(a, i / 2, Math.Min(i, n - 1), x);
        }

        public static int TimKiemNoiSuy(int [] a, int n, int k)
        {
            int low = 0, high = n - 1, mid;
            while (a[high] != a[low] && k >= a[low] && k <= a[high])
            {
                mid = low + ((k - a[low]) * (high - low) / (a[high] - a[low]));
                if (k == a[mid])
                {
                    return mid;
                }
                else if (k < a[mid])
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            if (k == a[low])
            {
                return low;
            }
            else
            {
                return -1;
            }
        }
    

            public static void timkiem(int[] a, int n)
        {
            int result;
            int chon;
            Console.WriteLine("Nhap so x can tim kiem trong mang: ");
            int x = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("\n********************THUẬT TOÁN TÌM KIẾM SẮP XẾP************************");
                Console.WriteLine("1.THUẬT TOÁN TIM KIẾM TUYẾN TÍNH");
                Console.WriteLine("2.THUẬT TOÁN TIM KIẾM NHỊ PHÂN");
                Console.WriteLine("3.THUẬT TOÁN TIM KIẾM TAM PHÂN");
                Console.WriteLine("4.THUẬT TOÁN TIM KIẾM JUMP SEARCH");
                Console.WriteLine("5.THUẬT TOÁN TIM KIẾM THEO SỐ MŨ");
                Console.WriteLine("6.THUẬT TOÁN TIM KIẾM NỘI SUY");
                Console.WriteLine("7.QUAY LẠI: ");

                Console.WriteLine("NHẬP LỰA CHỌN CỦA BẠN VÀO MÀN HÌNH");
                chon = int.Parse(Console.ReadLine());

                switch (chon)
                {
                    case 1:
                        result = TimKiemTuyenTinh(a, x);
                        if (TimKiemTuyenTinh(a, x) == -1)
                            Console.WriteLine("Phan tu khong ton tai trong mang");
                        else
                            Console.WriteLine("Phan tu can tim kiem la phan tu a[" + result + "]");
                        break;

                    case 2:
                        result = TimKiemNhiPhan(a, 0, n - 1, x);
                        if (TimKiemNhiPhan(a, 0, n - 1, x) == -1)
                            Console.WriteLine("Phan tu khong ton tai trong mang");
                        else
                            Console.WriteLine("Phan tu can tim kiem la phan tu a[" + result + "]");
                        break;

                    case 3:
                        result = TimKiemTamPhan(0, n - 1, x, a);
                        if (TimKiemTamPhan(0, n - 1, x, a) == -1)
                            Console.WriteLine("Phan tu khong ton tai trong mang");
                        else
                            Console.WriteLine("Phan tu can tim kiem la phan tu a[" + result + "]");
                        break;

                    case 4:
                        result = jumpSearch(a, x);
                        if (jumpSearch(a, x) == -1)
                            Console.WriteLine("Phan tu khong ton tai trong mang");
                        else
                            Console.WriteLine("Phan tu can tim kiem la phan tu a[" + result + "]");
                        break;

                    case 5:
                        result = TimKiemMu(a, n, x);
                        if (TimKiemMu(a, n, x) == -1)
                            Console.WriteLine("Phan tu khong ton tai trong mang");
                        else
                            Console.WriteLine("Phan tu can tim kiem la phan tu a[" + result + "]");
                        break;

                    case 6:
                        result = TimKiemNoiSuy(a, n, x);
                        if (TimKiemNoiSuy(a, n, x) == -1)
                            Console.WriteLine("Phan tu khong ton tai trong mang");
                        else
                            Console.WriteLine("Phan tu can tim kiem la phan tu a[" + result + "]");
                        break;


                    case 7:
                        
                        break;
                }
            } while (chon != 7);
        }
    }
}
