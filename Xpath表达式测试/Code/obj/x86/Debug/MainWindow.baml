   M S B A M L   `   `   `  ����[  WSystem.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089Y@clr-namespace:System.Windows.Forms;assembly=System.Windows.FormsSystem.Windows.Forms  5   	    XpathSample   XpathSample.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Owf@clr-namespace:System.Windows.Forms;assembly=System.Windows.Forms     5   	   -   5          � Title$  XPATH Inspector��5   	   $��651.97��6!   $	��579��61    � WindowStyle$ ThreeDBorderWindow=�6T    � WindowStartupLocation$ CenterScreen=�6u    � 
ResizeMode$ CanMinimize=�6�   .��5      � $��0,4,0,8q�6    � ColumnDefinitions 5   
   �� 5	      $	��58* �6   �� 5
      $
��151* �6   �� 5      $
��766* �6   .+�5   
   �� -   5        $��txtxml��5   M   $	��235��6   $
��Left=�6   $��	12,78,0,0q�6:   $	��Top=�6[   $	��550��6s    �� TextWrapping$
 Wrap=�6   " �� VerticalScrollBarVisibility$ Visible=�6�   $�� ��6�   $��14(�6�   $��3��6�   .��6�   5      �� 5   
   -   5        $��txtqueryxpath��5   2   $��33��6   $��
12,39,13,0q�6   $	��Top=�6G   
���   �$
��Bold"�6r   $��Verdana)�6�   $��16(�6�   $�� ��6�   $��3��6�   .��6�   5      �� 5   
   -   5        $��txtresultxpath��5   N   $	��122��6   $
��Left=�6   $��
12,476,0,0q�6:   $
 Wrap=�6d   $	��Top=�6x   $ Visible=�6�   $	��550��6�   $��14(�6�   $��3��6�   .��6�   5      �� 5   
   -   5        $��
btnOpenxml��5   e   $��Open an xml file��6   $��33��6,   $
��Left=�68   $��12,3,0,0q�6S   $	��Top=�6w   $	��101��6�   $��2��6�   �� 5   
   -   5        $��btnxpathnavigator��5   �   $S��MPlease enter an XPath query in the textbox below and press here to execute it��6   $��34��6i   $
��Left=�6u   $��0,3,0,0q�6�   $	��Top=�6�   $	��437��6�   {�.  $��2��6  �� 5   
   -   5        $��label1��5   q   $!��Results of the XPath Query:��6   $��35��66   $
��Left=�6B   $��
12,435,0,0q�6]   $	��Top=�6   $	��242��6�   $��18(�6�   $��3��6�   5      5      