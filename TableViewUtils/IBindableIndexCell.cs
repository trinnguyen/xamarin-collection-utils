using System;
using UIKit;

namespace TableViewUtils
{
	public interface IBindableIndexCell<T>
	{
		void Bind(T cellViewModel, UITableView tableView, Foundation.NSIndexPath indexPath);
	}
}