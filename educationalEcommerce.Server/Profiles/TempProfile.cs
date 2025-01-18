//using AutoMapper;
//using educationalEcommerce.Server.Domain.Entities;

//namespace educationalEcommerce.Server.Profiles
//{
//    //public class SubObject1
//    //{
//    //    public Guid Id { get; set; }
//    //    public string Name { get; set; }
//    //    public int Number { get; set; }

//    //}
//    //public class SubObject2
//    //{
//    //    public Guid Id { get; set; }
//    //    public string Name { get; set; }
//    //    public int Number { get; set; }

//    //}

//    //public class Object1
//    //{
//    //    public Guid Id { get; set; }
//    //    public string Name { get; set; }
//    //    public int Number { get; set; }
//    //    public List<SubObject1> ListOfSubObject1 { get; set; }

//    //}
//    //public class Object2
//    //{
//    //    public Guid Id { get; set; }
//    //    public string Name { get; set; }
//    //    public string LastName { get; set; }
//    //    public int Number { get; set; }
//    //    public List<SubObject2> ListOfSubObject2 { get; set; }

//    //}
//    //public class Object3
//    //{
//    //    public Guid Id { get; set; }
//    //    public string Name { get; set; }
//    //    public string LastName { get; set; }
//    //    public double Price { get; set; }
//    //    public int Number { get; set; }
//    //}

//    //public class TempClass
//    //{
//    //    public Guid Id { get; set; }
//    //    public List<Object1> ListObject1 { get; set; }
//    //    public List<Object2> ListObject2 { get; set; }
//    //}
//    //public class TempClassDto
//    //{
//    //    public Guid Id { get; set; }
//    //    public List<Object3> ListObject3 { get; set; } = new List<Object3>();
//    //}
//    //public class TempProfile : Profile
//    //{
//    //    public TempProfile()
//    //    {
//    //        CreateMap<TempClass, TempClassDto>()
//    //             //.BeforeMap((src, dest, context) =>
//    //             //{
//    //             //    List<Object3> list1  = new List<Object3>();
//    //             //    List<Object3> list2 = new List<Object3>();
//    //             //    list1 = context.Mapper.Map<List<Object3>>(src.ListObject1.SelectMany(lob1 => lob1.ListOfSubObject1));
//    //             //    list2 = context.Mapper.Map<List<Object3>>(src.ListObject2.SelectMany(lob2 => lob2.ListOfSubObject2));
//    //             //    var l = list1.Concat(list2);
//    //             //    dest.ListObject3 = l.ToList();
//    //             //});
//    //             //.ForMember(dest => dest.ListObject3, opt => opt.Ignore());
//    //             //.ForMember(dest => dest.ListObject3,
//    //             //opt => opt.MapFrom(
//    //             //    src => src.ListObject1
//    //             //            .SelectMany(
//    //             //        lob1 => lob1.ListOfSubObject1
//    //             //        )

//    //             //            ));
//    //             .ForMember(dest => dest.ListObject3,
//    //                    opt => opt.MapFrom( (src, dest, context, b) => 
//    //                    {
//    //                        var l = src.ListObject2
//    //                        .SelectMany(lob1 => lob1.ListOfSubObject2);

//    //                        var n = b.Mapper.Map<List<Object3>>(l);

//    //                        return l.ToList();
//    //                    }

//    //                    ));


//    //        CreateMap<SubObject1, Object3>()
//    //            .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.Name + "hello"))
//    //            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name + "hello world"));

//    //        CreateMap<SubObject2, Object3>()
//    //            .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.Name + "hello"))
//    //            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name + "hello world"));



//    //    }
//    }
//}
