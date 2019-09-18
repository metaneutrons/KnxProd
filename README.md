# KnxProd

.NET Core 3.0 library for creating and editing KNX ETS XML and .knxprod files. This project heavily borrows code from thelsing's [CreateKnxProd](https://github.com/thelsing/CreateKnxProd).

Have a look at my implementation of a commandline tool for [mknx](https://github.com/metaneutrons/mknx) for an example how to use KnxProd library.

The library depends on external DLLs for the final creation (and signing) of the .knxprod file. There are two options for that:

### Option 1: Install ETS4

Install [KNX ETS4](https://knxcloud.org/index.php/s/NM7nG0yHtu7PoJO). The library will use the Dlls located at *C:\Program Files (x86)\ETS4* by default. If you have installed ETS4 elsewhere you can point the library to the path using the property *KnxProd.Ets4DllPath*.

### Option 2: Copy necessary Dlls

You can also copy the necessary Dlls out of an installed [KNX ETS4](https://knxcloud.org/index.php/s/NM7nG0yHtu7PoJO). You need:

        Knx.Ets.Converter.ConverterEngine.dll
        Knx.Ets.Converter.RegistrationRelevanceInformation.dll
        Knx.Ets.DynamicData.dll
        Knx.Ets.Xml.ObjectModel.dll
        Knx.Ets.Xml.ObjectModel.XmlSerializers.dll
        log4net.dll
        Ionic.Zip.dll

You have to point the library to the path of the Dlls by setting the property *KnxProd.Ets4DllPath*.