   M S B A M L   `   `   `  ����?  ;Bank, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:Bank.Views.Pages.Admin.DataViewBank.Views.Pages.Admin.DataView  5      2    ,Bank.Views.Pages.Admin.DataView.DataViewPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ?local-clr-namespace:Bank.Views.Pages.Admin.DataView     5      -   5          N� Title$  DataViewPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��0.3* �6   �� 5      $��* �6   �� 5      $
��0.3* �6   .+�5   
   � $��0��6   .+�5      ��  �� Orientation$ 
Horizontal=�6   $��Center=�62   $��Center=�6M   .+�5      �� $��
Поиск��6   $��19(�6)   $��80��67   �� 5      -   5         ��Name$ 	TxbSearch��5      $	��250��6-   $��19(�69   6G   5      �� 5      .+�5      �� -   5         ��Name$ 
ButtonBack��5      $��
Назад��6.   $
��Left=�6>   $	��144��6Y   $��30��6e   $��Bottom=�6q   6�   5      5      � 5!   
   $��1��6   .+�5#      �� .+�5%      &   System.Windows.Controls.DataGrid  -   5          Name$ DataView��5%         AutoGenerateColumns .     
IsReadOnly .    ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6[   	   Columns	 5'      0  *System.Windows.Controls.DataGridTextColumn  5)      ,  &System.Windows.Controls.DataGridColumn
   Header$
 ID��6.      Width$
 0.3* 6Q   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6:   �� *ID+6Q     5*      $
 Фамилия��6.   $ * 6\    6?   �� *
LastName+6\     5+      $
 Имя��6.   $ * 6Y    6;   �� *	FirstName+6Y     5,      $
 Отчество��6.   $ * 6_    6@   �� *
Patronymic+6_     5-      $
 Дата Выдачи��6.   $ * 6c    6C   �� *DateResults+6c     5.      $
 Кем выдан��6.   $ * 6`    6A   �� *
IssuedWhom+6`     5/      $
 Пол��6.   $ * 6V    6;   �� *Gender+6V     50      $
 Дата Рождения��6.   $ * 6c    6E   �� *	DateBrith+6c     51      $!
 Место рождения��6.   $ * 6e    6F   �� *
BirthPlace+6e     52      $!
 Серия паспорта��6.   $ * 6i    6F   �� *PassportSeries+6i     53      $!
 Номер паспорта��6.   $ * 6i    6F   �� *PassportNumber+6i   57      59      5;      � 5=   
   $��2��6   .+�5?      �� $ 
Horizontal=�6   $��Center=�62   $��Center=�6M   .+�5A      �� -   5        $ ButtonRemove��5A      $��Удалить��6/   $��Arial)�6A   $	��200��6T   $��30��6`   6l   �� 5B      -   5        $ 	ButtonAdd��5B      $��Добавить��6,   $��Arial)�6?   $	��200��6R   $��30��6^   $��	10 0 10 0q�6j   6}   �� 5C      -   5        $ 
ButtonEdit��5C      $ ��Редактировать��6-   $��Arial)�6E   $	��200��6X   $��30��6d   $��0 0 10 0q�6p   6�   �� 5D      -   5        $ 
ButtonInfo��5D      $��Информация��6-   $��Arial)�6B   $	��200��6U   $��30��6a   $��0 0 10 0q�6m   6   5H      5J      5L      5M      