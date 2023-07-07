using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
	/// <summary>
	/// https://leetcode.com/problems/contains-duplicate/
	/// </summary>
	public class ContainsDuplicate
	{

		public bool ContainsDuplicate(int[] nums)
		{
			
			Dictionary<int, int> dic = new Dictionary<int, int>();

			for (int i = 0; i < nums.Length - 1; i++)
			{

				if (dic.ContainsKey(nums[i]))
				{
					return true;
				}

				dic[nums[i]]=1;

			}

			return false;


		}

	}
}
