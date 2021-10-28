using System;

namespace Lession51
{

    namespace Lession51
    {
        public class Program
        {
            public int[] Reverse3(int[] nums)
            {
                var nums2 = new int[3];

                nums2[0] = nums[2];
                nums2[1] = nums[1];
                nums2[2] = nums[0];

                return nums2;
            }
            public int[] MaxEnd3(int[] nums)
            {
                // 1. Izgūt masīva pirmo elementu 

                int first = nums[0];
                int last = nums[2];

                // 1. Atrast lielāko vērtību

                int largest = Math.Max();

                // 2. Uzstādīt visas vērtības vienādas ar lielāko atrast

                nums[0] = largest;
                nums[1] = largest;
                nums[2] = largest;

                return nums;
            }
        }
    }
