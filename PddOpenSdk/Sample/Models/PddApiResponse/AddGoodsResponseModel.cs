using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiResponse
{
    public partial class AddGoodsResponseModel : PddResponseModel
    {
        /// <summary>
/// 商品ID
/// </summary>
[JsonProperty("商品ID")]
public string GoodsId {get;set;}
/// <summary>
/// 上传商品的上传序列ID
/// </summary>
[JsonProperty("上传商品的上传序列ID")]
public int GoodsCommitId {get;set;}
}
}

