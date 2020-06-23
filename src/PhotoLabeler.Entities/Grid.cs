﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoLabeler.Entities
{
	public class Grid
	{

		public enum Order
		{
			Ascending,
			Descending,
			Default
		}

		public class GridCell
		{

			public string Text { get; set; }

			public string Link { get; set; }
			
			public bool Selected { get; set; }


			public int CellIndex { get; set; }

			public GridRow Row { get; set; }

			public Grid Grid { get; set; }

		}

		public class GridHeaderCell : GridCell
		{

			public Order Order { get; set; } = Order.Default;
		}

		public class GridRow
		{

			public List<GridCell> Cells { get; set; } = new List<GridCell>();

			public int RowIndex { get; set; }

			public bool Visible { get; set; } = true;


			public Grid Grid { get; set; }


		}

		public class GridHeader
		{

			public GridRow Row { get; set; }

		}

		public class GridBody
		{

			public List<GridRow> Rows { get; set; } = new List<GridRow>();

		}

		public string Caption { get; set; }

		public GridHeader Header { get; set; }

		public GridBody Body { get; set; }

		public List<GridRow> AllRows
		{
			get
			{
				var list = new List<GridRow>();
				if (this.Header?.Row != null)
				{
					list.Add(this.Header.Row);
				}
				if (this.Body != null && this.Body.Rows != null)
				{
					list.AddRange(this.Body.Rows);
				}
				return list;
			}
		}

	}
}