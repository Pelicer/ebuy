   M S B A M L   `   `   `  ����?  ;eBuy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:eBuy.View.Product.RegistrationeBuy.View.Product.Registration  5   	   2    ,eBuy.View.Product.Registration.ACTBuyingDate   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   >local,clr-namespace:eBuy.View.Product.Registration     5   	   -   5          �Name$  BuyingDateScreen��5   	    � Title$ ACTBuyingDate��5   	   $	��329��6   $	��391��6,    � 
ResizeMode$ NoResize=�68    � Icon$* $/eBuy;component/Images/icon/icon.png��6N    � WindowStartupLocation$ CenterScreen=�6z    � WindowStyle$
 None=�6�   ���	#FF414141 � 	Resources 5	         NoHover �� 
TargetType �� Property	 �� Value
 �� 
TargetType ��Name �� Triggers P� Property P� Value  
BlueBorder��%�  &	        &	 �    �� 5
   
   " ��6    .�5      ��  �@�OverridesDefaultStyle	 . 66   �� 5       �@�Cursor$
	 Hand��6'   �� 5       � ��	 5      �� 5      "
 ��6&   .R�5      �� $ border��6!   $��0q�61   
���   �#��z��6Y   ._�5      �� $��Center=�6/   $��Center=�6L   5       5      P� 5       �@J�IsMouseOver . . �5   "   ��  �@J�Opacity$		 0.8Q�6<   5      5      5      5      �� 5   
   " ��6#   .�5      ��  �@�OverridesDefaultStyle	 . 66   �� 5       �@�Cursor$
	 Hand��6'   �� 5       � ��	 5       �� 5!      "
 ��6&   .R�5"      �� $ border��6!   $��1q�61   ���	#FF22C3FF#��z��6]   ._�5#      �� $��Center=�6/   $��Center=�6L   5$       5%      P� 5&       �@J�IsMouseOver . . �5'   "   ��  �@J�Opacity$		 0.8Q�6<   5(      5*      5,      5-      5.      .��5/      � .+�50   
   �� -   5         ��Name$ lblDate��50      $(��"Quando você comprou este produto?��6!   $
��Left=�6M   $	��Top=�6h   $��	10,10,0,0q�6�   $��21.333(�6�   
�������$	��371��6�   �� 51   
   -   5         ��Name$ 	btnUpdate��51      $��OK��6$   
�������$��1q�6D   #��[  6Y   $��16(�6z   $��140,289,136,10q�6�   6�   �� 52   
   -   5         ��Name$ txtDate��52      $��Center=�6#   $
��Left=�6G   $��32��6b    �� TextWrapping$
 Wrap=�6n   $	��Top=�6�   $	��371��6�   $��
10,252,0,0q�6�   
�������
�������$��0,0,0,1q�6�   $��21.333(�6  ��6�   Z� 6  &   System.Windows.Controls.Calendar  53   
   -   5          Name$ DateChooser��53      $
��Left=�6(   $	��Top=�6C   $��	98,79,0,0q�6[   6n   54      55      