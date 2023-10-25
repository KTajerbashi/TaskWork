﻿namespace TicketApplication.Common
{
    public class Paging
    {
        public int Page { get; set; } = 0;

        public void Prev()
        {
            Page--;
            if (Page == 0)
            {
                Page = 0;
            }
        }

        public void Next(int max, int count)
        {
            if (count <= max)
            {
                Page++;
            }
        }
        public string Order(int skip, int take = 23)
        {
            if (Page < 1)
            {
                skip = 0;
                Page = 0;
            }
            return $@"OFFSET {skip * take} ROWS FETCH NEXT {take} ROWS ONLY";
        }
    }
}
