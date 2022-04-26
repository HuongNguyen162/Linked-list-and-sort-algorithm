using System;

namespace ktr1_ctdlvagt
{
    class Program
    {
        private static void Quick_Sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                {
                    Quick_Sort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    Quick_Sort(arr, pivot + 1, right);
                }
            }

        }

        private static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while (true)
            {

                while (arr[left] < pivot)
                {
                    left++;
                }

                while (arr[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;

                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;


                }
                else
                {
                    return right;
                }
            }
        }
        private static void chentructiep(int[] a, int n)
        {
            int pos, x;
            for (int i = 0; i < n; i++)

            {
                x = a[i]; pos = i - 1;
                while ((pos >= 0) && (a[pos] > x))
                {
                    a[pos + 1] = a[pos];
                    pos--;
                }
                a[pos + 1] = x;



            }
        }
        private static void chontructiep(int[] a, int n)
        {
            int min;
            for (int i = 0; i < n - 1; i++)
            {
                min = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (a[j] < a[min])
                        min = j;

                    {
                        int doi = a[min];
                        a[min] = a[i];
                        a[i] = doi;

                    }
                }
            }
        }
        private static void doichotructiep(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[j] < a[i])

                    {
                        int doi = a[i];
                        a[i] = a[j];
                        a[j] = doi;

                    }
                }
            }
        }
        private static void heapSort(int[] arr, int n)
        {
            for (int i = n / 2 - 1; i >= 0; i--)
                heapify(arr, n, i);
            for (int i = n - 1; i >= 0; i--)
            {
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;
                heapify(arr, i, 0);
            }
        }
        private static void heapify(int[] arr, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            if (left < n && arr[left] > arr[largest])
                largest = left;
            if (right < n && arr[right] > arr[largest])
                largest = right;
            if (largest != i)
            {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;
                heapify(arr, n, largest);
            }
        }
        private static void thuattoannoibot(int[] a, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {


                for (int j = n - 1; j > i; j--)
                {
                    if (a[j] < a[j - 1])


                    {
                        int doi = a[j];
                        a[j] = a[j - 1];
                        a[j - 1] = doi;

                    }
                }
            }
        }
        private static void radixsort(int[] a, int n)
        {
            int m = a[0], exp = 1;
            int[] b = new int[100];

            for (int i = 0; i < n; i++)
                if (a[i] > m)
                    m = a[i];

            while (m / exp > 0)
            {
                int[] bucket = new int [100];
                for (int i = 0; i < n; i++)
                    bucket[a[i] / exp % 10]++;
                for (int i = 1; i < 10; i++)
                    bucket[i] += bucket[i - 1];
                for (int i = n - 1; i >= 0; i--)
                    b[--bucket[a[i] / exp % 10]] = a[i];
                for (int i = 0; i < n; i++)
                    a[i] = b[i];
                exp *= 10;
            }
        }
        private static void shellsort(int[] a, int n)
        {
            int kc, tg, i, j;
            for (kc = n / 2; kc > 0; kc /= 2)
            {
                for (i = kc; i < n; i += 1)
                {
                    tg = a[i];
                    for (j = i; j >= kc && a[j - kc] > tg; j -= kc)
                        a[j] = a[j - kc];
                    a[j] = tg;
                }
            }
        }
        private static void chennhiphan(int[] a, int n)
        {
            int l, r, m;
            int x;
            for (int i = 1; i < n; i++)
            {
                x = a[i]; l = 0;
                r = i - 1;
                while (l <= r)
                {
                    m = (l + r) / 2;
                    if (x < a[m]) r = m - 1;
                    else l = m + 1;
                }
                for (int j = i - 1; j >= l; j--)
                    a[j + 1] = a[j];
                a[l] = x;
            }
        }
        private static void demphanphoi(int[] a, int n)
        {
            int[] q = new int[n];
            int max = a[0];
            int min = a[0];
            for (int i = 1; i < n; i++)
            {
                if (a[i] > max)
                    max = a[i];
                else if (a[i] < min)
                    min = a[i];
            }

            int k = max - min + 1;
            int[] luu = new int[k];
            for (int i = 0; i < k; i++)
                luu[i] = 0;

            for (int i = 0; i < n; i++)
                luu[a[i] - min]++;
            for (int i = 1; i < k; i++)
                luu[i] += luu[i - 1];
            for (int i = 0; i < n; i++)
            {
                q[luu[a[i] - min] - 1] = a[i];
                luu[a[i] - min]--;
            }
            for (int i = 0; i < n; i++)
                a[i] = q[i];
        }

        static void nhap(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[" + i + "]=");
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        static void xuat(int[] a, int n)
        {
            Console.Write("Hien thi mang:\n");
            for (int i = 0; i < n; i++)
                Console.Write(a[i] + "\n");
        }
        public static void merge(int[] a, int p, int q, int r)
        {
            int n1 = q - p + 1;
            int n2 = r - q;
            int[] L = new int[n1];
            int[] M = new int[n2];
            int i, j, k;
            for (i = 0; i < n1; i++)
                L[i] = a[p + i];
            for (j = 0; j < n2; j++)
                M[j] = a[q + 1 + j];

            i = 0;
            j = 0;
            k = p;
            while (i < n1 && j < n2)
            {
                if (L[i] <= M[j])
                {
                    a[k] = L[i];
                    i++;
                }
                else
                {
                    a[k] = M[j];
                    j++;
                }
                k++;
            }
            while (i < n1)
            {
                a[k] = L[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                a[k] = M[j];
                j++;
                k++;
            }
        }

        public static void merge_sort(int[] a, int l, int r)
        {
            if (l < r)
            {
                int m = l + (r - l) / 2;
                merge_sort(a, l, m);
                merge_sort(a, m + 1, r);
                merge(a, l, m, r);
            }
        }
        public static void dmerge(int[] a, int n)
        {
            merge_sort(a, 0, n - 1);

        }
        private static void sharker(int[] a, int n)
        {
            int right, left, m;
            left = 0;
            right = m = n - 1;
            while (left < right)
            {
                for (int i = right; i > left; i--)
                {
                    if (a[i] < a[i - 1])
                    {

                        m = i;
                        int tam = a[i];
                        a[i] = a[i - 1];
                        a[i - 1] = tam;

                    }
                }
                left = m;
                for (int j = left; j < right; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int tam = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = tam;
                        m = j;
                    }
                }
                right = m;
            }
        }


        private static void nhapphimbatki()
        {
            Console.WriteLine("hãy nhập vào màn hình một phím bất kì để tiếp tục chương trình");

        }
       
        private static void sapxep(int[] a, int n)
        {
            int chon;
            do
            {

                Console.WriteLine("\n********************THUẬT TOÁN TÌM KIẾM SẮP XẾP************************");
                Console.WriteLine("01.THUẬT TOÁN SẮP XẾP :QUICK");
                Console.WriteLine("02.THUẬT TOÁN SẮP XẾP :CHÈN TRỰC TIẾP");
                Console.WriteLine("03.THUẬT TOÁN SẮP XẾP :CHỌN TRỰC TIẾP");
                Console.WriteLine("04.THUẬT TOÁN SẮP XẾP :ĐỔI CHỖ TRỰC TIẾP");
                Console.WriteLine("05.THUẬT TOÁN SẮP XẾP :HEAP SORT");
                Console.WriteLine("06.THUẬT TOÁN SẮP XẾP :NỔI BỘT");
                Console.WriteLine("07.THUẬT TOÁN SẮP XẾP :RADIX SORT");
                Console.WriteLine("08.THUẬT TOÁN SẮP XẾP :SHELL SORT");
                Console.WriteLine("09.THUẬT TOÁN SẮP XẾP :CHÈN NHỊ PHÂN");
                Console.WriteLine("10.THUẬT TOÁN SẮP XẾP :ĐẾM PHÂN PHỐI");
                Console.WriteLine("11.THUẬT TOÁN SẮP XẾP :SHAKER SORT");
                Console.WriteLine("12.THUẬT TOÁN SẮP XẾP :MERGE");
                Console.WriteLine("13. QUAY LẠI :");
                Console.WriteLine("NHẬP LỰA CHỌN CỦA BẠN VÀO MÀN HÌNH");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        Quick_Sort(a, 0, n - 1);
                        xuat(a, n);
                        break;
                    case 2:
                        chentructiep(a, n);
                        xuat(a, n);
                        break;
                    case 3:
                        chontructiep(a, n);
                        xuat(a, n);
                        break;
                    case 4:
                        doichotructiep(a, n);
                        xuat(a, n);
                        break;
                    case 5:
                        heapSort(a, n);
                        xuat(a, n);
                        break;
                    case 6:
                        thuattoannoibot(a, n);
                        xuat(a, n);
                        break;
                    case 7:
                        radixsort(a, n);
                        xuat(a, n);
                        break;
                    case 8:
                        shellsort(a, n);
                        xuat(a, n);
                        break;
                    case 9:
                        chennhiphan(a, n);
                        xuat(a, n);
                        break;
                    case 10:
                        demphanphoi(a, n);
                        xuat(a, n);
                        break;
                    case 11:
                        sharker(a, n);
                        xuat(a, n);
                        break;
                    case 12:
                        dmerge(a, n);
                        xuat(a, n);
                        break;
                    case 13:
                       
                        break;
                }
            } while (chon != 13);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("nhập vào màn hình vào số phần tử của mảng ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            nhap(a, n);
            int chon;

            do
            {
                Console.WriteLine("*********************************MENU**********************************");
                Console.WriteLine("01.SẮP XẾP");
                Console.WriteLine("02.TÌM KIẾM");
                Console.WriteLine("03.THOÁT CHƯƠNG TRÌNH :");
                Console.WriteLine("NHẬP LỰA CHỌN CỦA BẠN VÀO MÀN HÌNH");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        sapxep(a, n);
                        break;
                    case 2:
                        TimKiem.timkiem(a, n);
                        break;
                    case 3:
                        Console.WriteLine("tạm biệt nhé ,kết thức chương trình !");
                        break;
                }
            } while (chon != 3);

            
        }
    }
}
